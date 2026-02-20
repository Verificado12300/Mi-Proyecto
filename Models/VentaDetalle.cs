namespace SistemaPOS.Models
{
    public class VentaDetalle
    {
        public int VentaDetalleID { get; set; }
        public int VentaID { get; set; }
        public int ProductoID { get; set; }
        public int ProductoPresentacionID { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public decimal CantidadUnidadesBase { get; set; }
    }
}
