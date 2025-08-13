namespace SistemaGestionBiblioteca.Models
{
    public class Multa
    {
        public int Id { get; set; }

        public decimal Monto { get; set; }

        public int DiasRetraso { get; set; }

        public int PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; }
    }
}