namespace GasolineraAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? NombreUsuario { get; set; }
        public string? ContrasenaHash { get; set; }
        public string? Rol { get; set; } // "admin" o "empleado"
        public int? EmpleadoId { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}