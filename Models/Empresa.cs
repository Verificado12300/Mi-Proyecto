using System;

namespace SistemaPOS.Models
{
    public class Empresa
    {
        public int EmpresaID { get; set; }
        public string RUC { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Ubigeo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public byte[] Logo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
    }
}
