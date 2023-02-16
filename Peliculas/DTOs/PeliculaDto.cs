using Peliculas.Data;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.DTOs
{
    public class PeliculaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        [Display(Name = "Dia de estreno")]
        [DataType(DataType.Date)]
        public DateTime FechaEstreno { get; set; }
        public EnumPais PaisOrigen { get; set; }
        public string Resumen { get; set; }
        public string PosterLink { get; set; }
        public string Director { get; set; }
        public List<ActorDto> Actores { get; set; }
        public List<ComentarioDto> Comentarios { get; set; }
        public GeneroDto Genero { get; set; }
        public List<CineDto> Cines { get; set; }

        public List<CriticaDto> Criticas { get; set; }
        public string TrailerLink { get; set; }

        public bool EnCartelara { get; set; }
    }
}
