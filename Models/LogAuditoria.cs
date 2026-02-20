using System;

namespace SistemaPOS.Models
{
    public class LogAuditoria
    {
        public int LogID { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioID { get; set; }
        public string Modulo { get; set; }
        public string Accion { get; set; }
        public string TablaAfectada { get; set; }
        public int? RegistroID { get; set; }
        public string ValorAnterior { get; set; }
        public string ValorNuevo { get; set; }
        public string DireccionIP { get; set; }
        public string Detalles { get; set; }
    }
}
