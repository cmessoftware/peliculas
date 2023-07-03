using Movies.Data;
using Movies.Web.Enums;
using Movies.WebApi.Dto.Cines;
using Movies.WebApi.Dto.Criticas;
using Movies.WebApi.Dto.Genero;
using System.ComponentModel.DataAnnotations;

namespace Movies.WebApi.Dto
{
    public record MoviesDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool OnBillBoard { get; set; }

        public int ReleaseDate { get; set; }
        public EnumCountry OriginCountry { get; set; }
        public string Summary { get; set; }
        public string Director { get; set; }
        public string PosterLink { get; set; }
        public string TrailerLink { get; set; }
        public List<ComentarioDto> Comments { get; set; }
        public List<GeneroDto> Genders { get; set; }
        public List<CinemaDto> Cinemas { get; set; }

        public List<ActorDto> Actors { get; set; }

        public List<CriticaDto> Critics { get; set; }


    }
}



