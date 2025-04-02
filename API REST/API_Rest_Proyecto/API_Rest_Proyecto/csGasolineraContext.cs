using Microsoft.EntityFrameworkCore;
using GasolineraAPI.Models;

namespace GasolineraAPI.Data
{
    public class GasolineraContext : DbContext
    {
        public GasolineraContext(DbContextOptions<GasolineraContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Combustible> Combustibles { get; set; }
        public DbSet<Bomba> Bombas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<FormaPago> FormasPago { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Abastecimiento> Abastecimientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de relaciones y restricciones
            modelBuilder.Entity<Bomba>()
                .HasOne(b => b.Combustible)
                .WithMany()
                .HasForeignKey(b => b.CombustibleId);

            modelBuilder.Entity<Venta>()
                .Property(v => v.FechaVenta)
                .HasDefaultValueSql("GETDATE()");

            // Configuración de índices
            modelBuilder.Entity<Combustible>()
                .HasIndex(c => c.Nombre)
                .IsUnique();

            modelBuilder.Entity<Bomba>()
                .HasIndex(b => b.Codigo)
                .IsUnique();
        }
    }
}