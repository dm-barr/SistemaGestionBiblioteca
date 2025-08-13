using System.ComponentModel.DataAnnotations;

namespace SistemaGestionBiblioteca.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        public int LibroId { get; set; }
        public Libro Libro { get; set; }

        public string EstudianteId { get; set; } // ID del ApplicationUser con rol Estudiante
        public ApplicationUser Estudiante { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime FechaDevolucionEsperada { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaDevolucionReal { get; set; }

        public int? MultaId { get; set; }
        public Multa? Multa { get; set; }
    }
}