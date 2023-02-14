using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Entidades
{
    public class SalaDeCine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public decimal Precio { get; set; }
        public TipoSalaDeCine Tipo { get; set; }
        public int CineId { get; set; }
        public Cine Cine { get; set; }
    }
}