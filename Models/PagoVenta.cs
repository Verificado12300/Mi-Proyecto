using System;

namespace SistemaPOS.Models
{
    public class PagoVenta
    {
        public int PagoVentaID { get; set; }
        public int PagoID { get; set; }
        public int VentaID { get; set; }
        public decimal MontoAplicado { get; set; }
    }
}