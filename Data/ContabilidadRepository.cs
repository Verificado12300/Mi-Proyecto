using SistemaPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SistemaPOS.Data
{
    public class ContabilidadRepository
    {
        /// <summary>
        /// Crea un asiento contable y retorna el ID generado.
        /// </summary>
        public static long CrearAsiento(Asiento asiento, SQLiteConnection connection, SQLiteTransaction transaction)
        {
            string query = @"
                INSERT INTO Asientos (FechaHora, TipoOperacion, Documento, Usuario, Observacion)
                VALUES (@FechaHora, @TipoOperacion, @Documento, @Usuario, @Observacion)";

            using (var cmd = new SQLiteCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@FechaHora", asiento.FechaHora.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@TipoOperacion", asiento.TipoOperacion);
                cmd.Parameters.AddWithValue("@Documento", (object)asiento.Documento ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Usuario", (object)asiento.Usuario ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Observacion", (object)asiento.Observacion ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }

            return connection.LastInsertRowId;
        }

        /// <summary>
        /// Agrega una linea de detalle a un asiento existente.
        /// </summary>
        public static void AgregarDetalle(AsientoDetalle detalle, SQLiteConnection connection, SQLiteTransaction transaction)
        {
            string query = @"
                INSERT INTO AsientosDetalle (IdAsiento, IdCuenta, Debe, Haber)
                VALUES (@IdAsiento, @IdCuenta, @Debe, @Haber)";

            using (var cmd = new SQLiteCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@IdAsiento", detalle.IdAsiento);
                cmd.Parameters.AddWithValue("@IdCuenta", detalle.IdCuenta);
                cmd.Parameters.AddWithValue("@Debe", detalle.Debe);
                cmd.Parameters.AddWithValue("@Haber", detalle.Haber);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Guarda un asiento contable completo (cabecera + detalles) en una transaccion.
        /// Valida que la suma de Debe == suma de Haber antes de guardar.
        /// </summary>
        public static bool GuardarAsientoCompleto(Asiento asiento, List<AsientoDetalle> detalles)
        {
            // Validar partida doble
            decimal totalDebe = 0;
            decimal totalHaber = 0;
            foreach (var d in detalles)
            {
                totalDebe += d.Debe;
                totalHaber += d.Haber;
            }

            if (totalDebe != totalHaber)
                throw new Exception($"El asiento no cuadra: Debe={totalDebe}, Haber={totalHaber}");

            using (var connection = DatabaseConnection.GetConnection())
            {
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        long idAsiento = CrearAsiento(asiento, connection, transaction);

                        foreach (var detalle in detalles)
                        {
                            detalle.IdAsiento = (int)idAsiento;
                            AgregarDetalle(detalle, connection, transaction);
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Obtiene el IdCuenta por codigo, usando una conexion/transaccion existente.
        /// </summary>
        public static int ObtenerIdCuenta(string codigo, SQLiteConnection connection, SQLiteTransaction transaction)
        {
            string query = "SELECT IdCuenta FROM CuentasContables WHERE Codigo = @Codigo AND Activa = 1";
            using (var cmd = new SQLiteCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                var result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    throw new Exception($"Cuenta contable '{codigo}' no encontrada.");
                return Convert.ToInt32(result);
            }
        }

        /// <summary>
        /// Calcula el costo promedio ponderado de un producto replicando la logica del kardex.
        /// Usa la conexion/transaccion existente para mantenerse dentro de la transaccion de venta.
        /// </summary>
        public static decimal ObtenerCostoPromedioProducto(int productoID, SQLiteConnection connection, SQLiteTransaction transaction)
        {
            decimal stock = 0;
            decimal valor = 0;

            string query = @"
                SELECT Entrada, Salida, CostoUnitario FROM (
                    -- Compras (entradas)
                    SELECT
                        cd.CantidadUnidadesBase AS Entrada,
                        0 AS Salida,
                        cd.CostoUnitario,
                        datetime(c.Fecha || ' ' || c.Hora) AS FechaHora
                    FROM CompraDetalles cd
                    INNER JOIN Compras c ON c.CompraID = cd.CompraID
                    WHERE cd.ProductoID = @ProductoID AND c.Estado != 'ANULADA'

                    UNION ALL

                    -- Ventas completadas (salidas)
                    SELECT
                        0 AS Entrada,
                        vd.CantidadUnidadesBase AS Salida,
                        COALESCE(pp.CostoBase, 0) AS CostoUnitario,
                        datetime(v.Fecha || ' ' || v.Hora) AS FechaHora
                    FROM VentaDetalles vd
                    INNER JOIN Ventas v ON v.VentaID = vd.VentaID
                    LEFT JOIN ProductoPresentaciones pp ON pp.ProductoPresentacionID = vd.ProductoPresentacionID
                    WHERE vd.ProductoID = @ProductoID AND v.Estado NOT IN ('ANULADA')

                    UNION ALL

                    -- Ajustes entrada
                    SELECT
                        a.Cantidad AS Entrada, 0 AS Salida, 0 AS CostoUnitario,
                        datetime(a.Fecha) AS FechaHora
                    FROM Ajustes a
                    WHERE a.ProductoID = @ProductoID AND a.TipoAjuste = 'ENTRADA'

                    UNION ALL

                    -- Ajustes salida
                    SELECT
                        0 AS Entrada, a.Cantidad AS Salida, 0 AS CostoUnitario,
                        datetime(a.Fecha) AS FechaHora
                    FROM Ajustes a
                    WHERE a.ProductoID = @ProductoID AND a.TipoAjuste = 'SALIDA'
                ) m
                ORDER BY FechaHora";

            using (var cmd = new SQLiteCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@ProductoID", productoID);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal entrada = Convert.ToDecimal(reader.GetValue(0));
                        decimal salida = Convert.ToDecimal(reader.GetValue(1));
                        decimal costoUnitario = Convert.ToDecimal(reader.GetValue(2));

                        if (entrada > 0)
                        {
                            decimal costo = costoUnitario > 0 ? costoUnitario : (stock > 0 ? valor / stock : 0);
                            stock += entrada;
                            valor += entrada * costo;
                        }
                        else if (salida > 0)
                        {
                            decimal costoPromedio = stock > 0 ? valor / stock : 0;
                            stock -= salida;
                            valor -= salida * costoPromedio;
                            if (stock <= 0) { stock = 0; valor = 0; }
                        }
                    }
                }
            }

            return stock > 0 ? Math.Round(valor / stock, 4) : 0;
        }

        /// <summary>
        /// Obtiene todas las cuentas contables activas.
        /// </summary>
        public static List<CuentaContable> ObtenerCuentas()
        {
            var cuentas = new List<CuentaContable>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT IdCuenta, Codigo, Nombre, Tipo, Activa FROM CuentasContables WHERE Activa = 1 ORDER BY Codigo";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cuentas.Add(new CuentaContable
                            {
                                IdCuenta = reader.GetInt32(0),
                                Codigo = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                Tipo = reader.GetString(3),
                                Activa = reader.GetInt32(4) == 1
                            });
                        }
                    }
                }
            }

            return cuentas;
        }

        /// <summary>
        /// Obtiene una cuenta contable por su codigo.
        /// </summary>
        public static CuentaContable ObtenerCuentaPorCodigo(string codigo)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT IdCuenta, Codigo, Nombre, Tipo, Activa FROM CuentasContables WHERE Codigo = @Codigo";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new CuentaContable
                            {
                                IdCuenta = reader.GetInt32(0),
                                Codigo = reader.GetString(1),
                                Nombre = reader.GetString(2),
                                Tipo = reader.GetString(3),
                                Activa = reader.GetInt32(4) == 1
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
