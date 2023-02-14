using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Entidades
{
    public class Genero
    {
     //   [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Pelicula> Peliculas { get; set; }
    }
}