using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SistemaGestionBiblioteca.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Nombre { get; set; }
        public string? FotoPath { get; set; } // Ruta de la foto

        // Propiedad de navegación para los préstamos del estudiante
        public ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
    }
}