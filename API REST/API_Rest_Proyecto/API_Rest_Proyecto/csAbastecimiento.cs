namespace GasolineraAPI.Models
{
    public class Abastecimiento
    {
        public int Id { get; set; }
        public int BombaId { get; set; }
        public int EmpleadoId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total => Cantidad * PrecioUnitario;
        public string? NumeroFactura { get; set; } // Cambiado a nullable
        public string? Proveedor { get; set; } // Cambiado a nullable
        public DateTime FechaAbastecimiento { get; set; } = DateTime.Now;
    }
}