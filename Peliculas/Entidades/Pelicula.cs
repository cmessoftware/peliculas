using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Peliculas.DTOs;

namespace Peliculas.Entidades
{
    public class Pelicula
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public DateTime? FechaEstreno { get; set; }
        public string? PaisOrigen { get; set; }

        public string? Resumen { get; set; }

        public string? Director { get; set; }

        public string? PosterLink { get; set; }

        /// <summary>
        /// Relación muchos a muchos -> tabla intermedia se crea a mano
        /// </summary>
        public List<PeliculaActor> PeliculasActores { get; set; }

        /// <summary>
        /// Relación 1 a muchos -> tabla intermedia se crea automaticamente
        /// </summary>
        [NotMapped]
        public List<Comentario> Comentarios { get; set; }

        /// <summary>
        /// Relación 1 a muchos -> tabla intermedia se crea automaticamente
        /// </summary>
        [NotMapped] 
        public List<Genero> Genero { get; set; }

        /// <summary>
        /// Relación 1 a muchos -> tabla intermedia se crea automaticamente
        /// </summary>
        [NotMapped]
        public List<Critica> Criticas { get; set; }

        /// <summary>
        /// Relación 1 a muchos -> tabla intermedia se crea automaticamente
        /// </summary>
        [NotMapped]
        public List<SalaDeCine> SalasDeCine { get; set; }

    }
}
