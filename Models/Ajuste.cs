using System;

namespace SistemaPOS.Models
{
    public class Ajuste
    {
        public int AjusteID { get; set; }
        public int ProductoID { get; set; }
        public string TipoAjuste { get; set; } // ENTRADA, SALIDA, CORRECCION
        public decimal Cantidad { get; set; }
        public decimal StockAnterior { get; set; }
        public decimal StockNuevo { get; set; }
        public string Motivo { get; set; }
        public int UsuarioID { get; set; }
        public DateTime Fecha { get; set; }
    }
}
