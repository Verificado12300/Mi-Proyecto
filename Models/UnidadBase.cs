namespace SistemaPOS.Models
{
    public class UnidadBase
    {
        public int UnidadID { get; set; }
        public string Nombre { get; set; }
        public string Simbolo { get; set; }
        public string Tipo { get; set; } // PESO, VOLUMEN, UNIDAD
        public bool Activo { get; set; }
    }
}
