using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Peliculas.DTOs;

namespace Peliculas.Entidades
{
    public class Pelicula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string PaisOrigen { get; set; }

        public string Resumen { get; set; }

        public string Director { get; set; }

        public string PosterLink { get; set; }

        public List<Actor> Actores { get; set; }

        public List<Comentario> Comentarios { get; set; }

        public Genero Genero { get; set; }

        public List<Cine> Cines { get; set; }

        public List<Critica> Criticas { get; set; }

        public string TrailerLink { get; set; }
    }
}
