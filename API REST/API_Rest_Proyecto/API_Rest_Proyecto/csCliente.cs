namespace GasolineraAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Nit { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}