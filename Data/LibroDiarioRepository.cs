using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaPOS.Models;

namespace SistemaPOS.Data
{
    public class LibroDiarioRepository
    {
        public static List<MovimientoDiario> ObtenerMovimientos(DateTime fechaDesde, DateTime fechaHasta,
            string tipoFiltro = null, string busqueda = null)
        {
            var movimientos = new List<MovimientoDiario>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT Fecha, Hora, Tipo, Descripcion, Referencia, Ingreso, Egreso, MetodoPago, Usuario
                    FROM (
                        -- VENTAS
                        SELECT v.Fecha, v.Hora, 'VENTA' as Tipo,
                               'Venta ' || v.TipoComprobante || ' - ' || COALESCE(c.Nombres || ' ' || c.Apellidos, c.RazonSocial, 'Cliente General') as Descripcion,
                               v.NumeroVenta as Referencia,
                               v.Total as Ingreso, 0 as Egreso,
                               v.MetodoPago, u.NombreCompleto as Usuario
                        FROM Ventas v
                        LEFT JOIN Clientes c ON v.ClienteID = c.ClienteID
                        INNER JOIN Usuarios u ON v.UsuarioID = u.UsuarioID
                        WHERE v.Estado != 'ANULADA'

                        UNION ALL

                        -- COMPRAS
                        SELECT co.Fecha, co.Hora, 'COMPRA' as Tipo,
                               'Compra ' || co.TipoComprobante || ' - ' || p.RazonSocial as Descripcion,
                               co.NumeroCompra as Referencia,
                               0 as Ingreso, co.Total as Egreso,
                               co.MetodoPago, u.NombreCompleto as Usuario
                        FROM Compras co
                        INNER JOIN Proveedores p ON co.ProveedorID = p.ProveedorID
                        INNER JOIN Usuarios u ON co.UsuarioID = u.UsuarioID
                        WHERE co.Estado != 'ANULADA'

                        UNION ALL

                        -- GASTOS
                        SELECT g.Fecha, g.Hora, 'GASTO' as Tipo,
                               g.Categoria || ' - ' || g.Concepto as Descripcion,
                               COALESCE(g.Comprobante, 'S/N') as Referencia,
                               0 as Ingreso, g.Monto as Egreso,
                               g.MetodoPago, u.NombreCompleto as Usuario
                        FROM Gastos g
                        INNER JOIN Usuarios u ON g.UsuarioID = u.UsuarioID

                        UNION ALL

                        -- PAGOS DE CLIENTES
                        SELECT pg.FechaPago as Fecha, pg.HoraPago as Hora, 'PAGO_CLIENTE' as Tipo,
                               'Cobro de cliente - ' || COALESCE(c.Nombres || ' ' || c.Apellidos, c.RazonSocial, '') as Descripcion,
                               'PAGO-' || pg.PagoID as Referencia,
                               pg.Monto as Ingreso, 0 as Egreso,
                               pg.MetodoPago, '' as Usuario
                        FROM Pagos pg
                        INNER JOIN Clientes c ON pg.ClienteID = c.ClienteID

                        UNION ALL

                        -- PAGOS A PROVEEDORES
                        SELECT pp.Fecha, pp.Hora, 'PAGO_PROVEEDOR' as Tipo,
                               'Pago a proveedor - ' || pr.RazonSocial as Descripcion,
                               COALESCE(pp.Comprobante, 'PAGO-' || pp.PagoProveedorID) as Referencia,
                               0 as Ingreso, pp.Monto as Egreso,
                               pp.MetodoPago, u.NombreCompleto as Usuario
                        FROM PagosProveedores pp
                        INNER JOIN CuentasPorPagar cp ON pp.CuentaPorPagarID = cp.CuentaPorPagarID
                        INNER JOIN Proveedores pr ON cp.ProveedorID = pr.ProveedorID
                        INNER JOIN Usuarios u ON pp.UsuarioID = u.UsuarioID
                    ) AS movimientos
                    WHERE Fecha >= @FechaDesde AND Fecha <= @FechaHasta";

                if (!string.IsNullOrEmpty(tipoFiltro) && tipoFiltro != "TODOS")
                    query += " AND Tipo = @TipoFiltro";
                if (!string.IsNullOrEmpty(busqueda))
                    query += " AND (Descripcion LIKE @Busqueda OR Referencia LIKE @Busqueda)";

                query += " ORDER BY Fecha DESC, Hora DESC";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta.ToString("yyyy-MM-dd"));

                    if (!string.IsNullOrEmpty(tipoFiltro) && tipoFiltro != "TODOS")
                        cmd.Parameters.AddWithValue("@TipoFiltro", tipoFiltro);
                    if (!string.IsNullOrEmpty(busqueda))
                        cmd.Parameters.AddWithValue("@Busqueda", $"%{busqueda}%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            movimientos.Add(new MovimientoDiario
                            {
                                Fecha = DateTime.Parse(reader.GetString(0)),
                                Hora = TimeSpan.Parse(reader.GetString(1)),
                                Tipo = reader.GetString(2),
                                Descripcion = reader.GetString(3),
                                Referencia = reader.GetString(4),
                                Ingreso = reader.GetDecimal(5),
                                Egreso = reader.GetDecimal(6),
                                MetodoPago = reader.GetString(7),
                                Usuario = reader.GetString(8)
                            });
                        }
                    }
                }
            }

            return movimientos;
        }

        public static (decimal TotalIngresos, decimal TotalEgresos) ObtenerTotales(DateTime fechaDesde, DateTime fechaHasta)
        {
            decimal totalIngresos = 0, totalEgresos = 0;

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT
                        COALESCE(SUM(CASE WHEN Estado != 'ANULADA' THEN Total ELSE 0 END), 0)
                    FROM Ventas WHERE Fecha >= @FD AND Fecha <= @FH";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FD", fechaDesde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FH", fechaHasta.ToString("yyyy-MM-dd"));
                    totalIngresos += Convert.ToDecimal(cmd.ExecuteScalar());
                }

                query = "SELECT COALESCE(SUM(Monto), 0) FROM Pagos WHERE FechaPago >= @FD AND FechaPago <= @FH";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FD", fechaDesde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FH", fechaHasta.ToString("yyyy-MM-dd"));
                    totalIngresos += Convert.ToDecimal(cmd.ExecuteScalar());
                }

                query = @"
                    SELECT
                        COALESCE(SUM(CASE WHEN Estado != 'ANULADA' THEN Total ELSE 0 END), 0)
                    FROM Compras WHERE Fecha >= @FD AND Fecha <= @FH";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FD", fechaDesde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FH", fechaHasta.ToString("yyyy-MM-dd"));
                    totalEgresos += Convert.ToDecimal(cmd.ExecuteScalar());
                }

                query = "SELECT COALESCE(SUM(Monto), 0) FROM Gastos WHERE Fecha >= @FD AND Fecha <= @FH";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FD", fechaDesde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FH", fechaHasta.ToString("yyyy-MM-dd"));
                    totalEgresos += Convert.ToDecimal(cmd.ExecuteScalar());
                }

                query = "SELECT COALESCE(SUM(Monto), 0) FROM PagosProveedores WHERE Fecha >= @FD AND Fecha <= @FH";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FD", fechaDesde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@FH", fechaHasta.ToString("yyyy-MM-dd"));
                    totalEgresos += Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }

            return (totalIngresos, totalEgresos);
        }
    }
}
