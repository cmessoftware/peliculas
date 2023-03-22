using Peliculas.Data;
using Peliculas.Entidades;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.DTOs
{
    public class PeliculaDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        [Display(Name = "Dia de estreno")]
        [DataType(DataType.Date)]
        public DateTime FechaEstreno { get; set; }
        public string PaisOrigen { get; set; }
        public string Resumen { get; set; }
        public string Director { get; set; }
        public string PosterLink { get; set; }
        public string TrailerLink { get; set; }
        public List<ActorPeliculaRelDto> PeliculaActores { get; set; }
        public List<ComentarioDto> Comentarios { get; set; }
        public List<GeneroDto> Generos { get; set; }
        public List<SalaDto> SalasCines { get; set; }
        public List<CriticaDto> Criticas { get; set; }

        //public bool EnCartelara { get; set; }
    }
}
