using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SistemaPOS.Data
{
    public class FlujoCajaItem
    {
        public string Concepto { get; set; }
        public decimal Ingreso { get; set; }
        public decimal Egreso { get; set; }
    }

    public class FlujoCajaRepository
    {
        public static List<FlujoCajaItem> ObtenerFlujoCaja(DateTime fechaDesde, DateTime fechaHasta)
        {
            var items = new List<FlujoCajaItem>();
            string fd = fechaDesde.ToString("yyyy-MM-dd");
            string fh = fechaHasta.ToString("yyyy-MM-dd");

            using (var connection = DatabaseConnection.GetConnection())
            {
                // Ventas en efectivo
                items.Add(new FlujoCajaItem
                {
                    Concepto = "Ventas - Efectivo",
                    Ingreso = ObtenerSuma(connection, "SELECT COALESCE(SUM(MontoEfectivo), 0) FROM Ventas WHERE Fecha >= @FD AND Fecha <= @FH AND Estado != 'ANULADA' AND Estado != 'CREDITO'", fd, fh)
                });

                // Ventas Yape
                items.Add(new FlujoCajaItem
                {
                    Concepto = "Ventas - Yape",
                    Ingreso = ObtenerSuma(connection, "SELECT COALESCE(SUM(MontoYape), 0) FROM Ventas WHERE Fecha >= @FD AND Fecha <= @FH AND Estado != 'ANULADA' AND Estado != 'CREDITO'", fd, fh)
                });

                // Ventas Tarjeta
                items.Add(new FlujoCajaItem
                {
                    Concepto = "Ventas - Tarjeta",
                    Ingreso = ObtenerSuma(connection, "SELECT COALESCE(SUM(MontoTarjeta), 0) FROM Ventas WHERE Fecha >= @FD AND Fecha <= @FH AND Estado != 'ANULADA' AND Estado != 'CREDITO'", fd, fh)
                });

                // Ventas Transferencia
                items.Add(new FlujoCajaItem
                {
                    Concepto = "Ventas - Transferencia",
                    Ingreso = ObtenerSuma(connection, "SELECT COALESCE(SUM(MontoTransferencia), 0) FROM Ventas WHERE Fecha >= @FD AND Fecha <= @FH AND Estado != 'ANULADA' AND Estado != 'CREDITO'", fd, fh)
                });

                // Cobros a clientes
                items.Add(new FlujoCajaItem
                {
                    Concepto = "Cobros a Clientes",
                    Ingreso = ObtenerSuma(connection, "SELECT COALESCE(SUM(Monto), 0) FROM Pagos WHERE FechaPago >= @FD AND FechaPago <= @FH", fd, fh)
                });

                // Compras (efectivo y transferencia, no crédito)
                items.Add(new FlujoCajaItem
                {
                    Concepto = "Compras",
                    Egreso = ObtenerSuma(connection, "SELECT COALESCE(SUM(Total), 0) FROM Compras WHERE Fecha >= @FD AND Fecha <= @FH AND Estado != 'ANULADA' AND Estado != 'CREDITO'", fd, fh)
                });

                // Gastos operativos
                items.Add(new FlujoCajaItem
                {
                    Concepto = "Gastos Operativos",
                    Egreso = ObtenerSuma(connection, "SELECT COALESCE(SUM(Monto), 0) FROM Gastos WHERE Fecha >= @FD AND Fecha <= @FH", fd, fh)
                });

                // Pagos a proveedores
                items.Add(new FlujoCajaItem
                {
                    Concepto = "Pagos a Proveedores",
                    Egreso = ObtenerSuma(connection, "SELECT COALESCE(SUM(Monto), 0) FROM PagosProveedores WHERE Fecha >= @FD AND Fecha <= @FH", fd, fh)
                });
            }

            // Filtrar items con valor 0
            items.RemoveAll(i => i.Ingreso == 0 && i.Egreso == 0);

            return items;
        }

        private static decimal ObtenerSuma(SQLiteConnection connection, string query, string fd, string fh)
        {
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@FD", fd);
                cmd.Parameters.AddWithValue("@FH", fh);
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }
    }
}
