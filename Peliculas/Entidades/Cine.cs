using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Entidades
{ 
    public class Cine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cadena { get; set; }
        public List<Pelicula> Peliculas { get; set; }

        public List<Sala> Salas { get; set; }

        public Direccion Direccion { get; set; }
    }
}