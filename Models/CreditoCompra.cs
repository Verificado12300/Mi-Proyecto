using System;

namespace SistemaPOS.Models
{
    public class CreditoCompra
    {
        public int CreditoCompraID { get; set; }
        public int CompraID { get; set; }
        public int ProveedorID { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; } // PENDIENTE, PAGADO, VENCIDO
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaPago { get; set; }
    }
}
