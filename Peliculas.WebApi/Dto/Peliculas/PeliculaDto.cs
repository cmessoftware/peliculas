using Peliculas.Data;
using Peliculas.Web.Dto;
using Peliculas.WebApi.Dto.Genero;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.WebApi.Dto
{
    public class PeliculaDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool EnCartelara { get; set; }

        [Display(Name = "Fecha de estreno")]
        public int Estreno { get; set; }
        public EnumPais PaisOrigen { get; set; }
        public string Resumen { get; set; }
        public string Director { get; set; }
        public string PosterLink { get; set; }
        public string TrailerLink { get; set; }
        public List<ComentarioDto> Comentarios { get; set; }
        public List<GeneroDto> Generos { get; set; }
        public List<CineDto> Cines { get; set; }

        public List<ActorDto> Actores { get; set; }

        public List<CriticaDto> Criticas { get; set; }


    }
}



