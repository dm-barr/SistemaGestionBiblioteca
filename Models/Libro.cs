using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SistemaGestionBiblioteca.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es requerido")]
        [StringLength(200)]
        public string Titulo { get; set; }

        public int AutorId { get; set; }
        public Autor Autor { get; set; }

        [StringLength(100)]
        public string? Categoria { get; set; }

        public bool Disponible { get; set; } = true;

        public string? FotoPath { get; set; } // Ruta de la foto

        // Propiedad de navegación para los préstamos del libro
        public ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
    }
}