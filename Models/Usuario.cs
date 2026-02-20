using System;

namespace SistemaPOS.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int RolID { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? UltimoAcceso { get; set; }
        public bool Activo { get; set; }

        // Permisos de módulos
        public bool PermisoVentas { get; set; } = true;
        public bool PermisoClientes { get; set; } = true;
        public bool PermisoCompras { get; set; }
        public bool PermisoInventario { get; set; }
        public bool PermisoReportes { get; set; }
        public bool PermisoConfiguracion { get; set; }
        public bool PermisoProveedores { get; set; }
        public bool PermisoFinanzas { get; set; }

        // Permisos de acciones especiales
        public bool PermisoDescuentos { get; set; }
        public bool PermisoAnularVentas { get; set; }
        public bool PermisoEliminarRegistros { get; set; }
        public bool PermisoVerCostos { get; set; }
        public bool PermisoModificarPrecios { get; set; }
        public bool PermisoFueraHorario { get; set; }

        // Propiedad para obtener el nombre del rol
        public string NombreRol { get; set; }
    }
}
