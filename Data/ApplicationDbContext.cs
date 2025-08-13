using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaGestionBiblioteca.Models;

namespace SistemaGestionBiblioteca.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Multa> Multas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configuración de relaciones
            builder.Entity<Libro>()
                .HasOne(l => l.Autor)
                .WithMany(a => a.Libros)
                .HasForeignKey(l => l.AutorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Prestamo>()
                .HasOne(p => p.Libro)
                .WithMany(l => l.Prestamos)
                .HasForeignKey(p => p.LibroId)
                .OnDelete(DeleteBehavior.Restrict); // Evita eliminación en cascada para mantener historial

            builder.Entity<Prestamo>()
                .HasOne(p => p.Estudiante)
                .WithMany(u => u.Prestamos)
                .HasForeignKey(p => p.EstudianteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Multa>()
                .HasOne(m => m.Prestamo)
                .WithOne(p => p.Multa)
                .HasForeignKey<Multa>(m => m.PrestamoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}