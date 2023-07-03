using Movies.Data;
using Movies.Web.Enums;

namespace Movies.WebApi.Dto.Actores
{
    public record ActorCreateRequestDto
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public string Biography { get; set; }

        public EnumCountry OriginCountry { get; set; }

        public string? UrlPhoto { get; set; }
    }
}