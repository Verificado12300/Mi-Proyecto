using System;

namespace SistemaPOS.Models
{
    public class CuentaPorPagar
    {
        public int CuentaPorPagarID { get; set; }
        public int CompraID { get; set; }
        public int ProveedorID { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal MontoPendiente { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Estado { get; set; }
    }
}
