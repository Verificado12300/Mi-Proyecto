namespace SistemaPOS.Models
{
    public class ConfigGeneral
    {
        public int ConfigID { get; set; }
        public string Clave { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; } // STRING, INTEGER, BOOLEAN, DECIMAL
        public string Categoria { get; set; }
    }
}
