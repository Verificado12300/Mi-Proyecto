using System;

namespace SistemaPOS.Models
{
    public class Asiento
    {
        public int IdAsiento { get; set; }
        public DateTime FechaHora { get; set; }
        public string TipoOperacion { get; set; } // VENTA, COMPRA, AJUSTE, ANULACION
        public string Documento { get; set; }
        public string Usuario { get; set; }
        public string Observacion { get; set; }
    }
}
