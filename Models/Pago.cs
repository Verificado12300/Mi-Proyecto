using System;

namespace SistemaPOS.Models
{
    public class Pago
    {
        public int PagoID { get; set; }
        public int ClienteID { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public decimal MontoEfectivo { get; set; }
        public decimal MontoYape { get; set; }
        public decimal MontoTransferencia { get; set; }
        public DateTime FechaPago { get; set; }
        public string HoraPago { get; set; }
        public string Observaciones { get; set; }
    }
}