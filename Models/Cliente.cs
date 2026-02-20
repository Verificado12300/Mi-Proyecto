using System;

namespace SistemaPOS.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string TipoDocumento { get; set; } // DNI, RUC, CE, PASAPORTE
        public string NumeroDocumento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public decimal LimiteCredito { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
    }
}
