namespace GasolineraAPI.Models
{
    public class Bomba
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }

        // Clave foránea
        public int CombustibleId { get; set; }

        // Propiedad de navegación (IMPORTANTE)
        public Combustible? Combustible { get; set; }

        public decimal CapacidadMaxima { get; set; }
        public decimal ExistenciaActual { get; set; }
        public string? Estado { get; set; }
    }
}