namespace GasolineraAPI.Models
{
    public class Combustible
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public string? Descripcion { get; set; }
    }
}