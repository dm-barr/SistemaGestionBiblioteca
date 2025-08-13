using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SistemaGestionBiblioteca.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }

        public string? FotoPath { get; set; } // Ruta de la foto

        // Propiedad de navegación para los libros del autor
        public ICollection<Libro> Libros { get; set; } = new List<Libro>();
    }
}