using System;

namespace SistemaPOS.Models
{
    public class MovimientoDiario
    {
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Referencia { get; set; }
        public decimal Ingreso { get; set; }
        public decimal Egreso { get; set; }
        public string MetodoPago { get; set; }
        public string Usuario { get; set; }
    }
}
