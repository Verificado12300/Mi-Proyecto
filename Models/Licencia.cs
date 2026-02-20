using System;

namespace SistemaPOS.Models
{
    public class Licencia
    {
        public int LicenciaID { get; set; }
        public string CodigoLicencia { get; set; }
        public string TipoLicencia { get; set; } // MENSUAL, ANUAL, PERPETUA
        public DateTime? FechaActivacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string Estado { get; set; } // ACTIVA, INACTIVA, VENCIDA
        public int EmpresaID { get; set; }
    }
}
