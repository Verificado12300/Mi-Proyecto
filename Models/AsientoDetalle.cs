namespace SistemaPOS.Models
{
    public class AsientoDetalle
    {
        public int IdDetalle { get; set; }
        public int IdAsiento { get; set; }
        public int IdCuenta { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
    }
}
