using System;

namespace SistemaPOS.Models
{
    public class PagoProveedor
    {
        public int PagoProveedorID { get; set; }
        public int CuentaPorPagarID { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public string Comprobante { get; set; }
        public string Observaciones { get; set; }
        public int UsuarioID { get; set; }
    }
}
