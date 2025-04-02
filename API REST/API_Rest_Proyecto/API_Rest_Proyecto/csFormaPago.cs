namespace GasolineraAPI.Models
{
    public class FormaPago
    {
        public int Id { get; set; }
        public string? Nombre { get; set; } // "Efectivo" o "Tarjeta"
        public bool RequiereReferencia { get; set; }
    }
}