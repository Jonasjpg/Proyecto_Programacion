namespace GasolineraAPI.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public int EmpleadoId { get; set; }
        public int BombaId { get; set; }
        public int FormaPagoId { get; set; }
        public decimal Cantidad { get; set; } // Galones despachados
        public decimal PrecioUnitario { get; set; }
        public decimal Total => Cantidad * PrecioUnitario;
        public DateTime FechaVenta { get; set; } = DateTime.Now;
        public string? ReferenciaPago { get; set; }
    }
}