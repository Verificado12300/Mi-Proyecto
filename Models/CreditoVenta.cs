using System;

namespace SistemaPOS.Models
{
    public class CreditoVenta
    {
        public int CreditoVentaID { get; set; }
        public int VentaID { get; set; }
        public int ClienteID { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaPago { get; set; }
    }
}
