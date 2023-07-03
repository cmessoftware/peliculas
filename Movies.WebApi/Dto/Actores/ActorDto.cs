using Movies.Web.Enums;

namespace Movies.WebApi.Dto
{
    public record ActorDto
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Biography { get; set; }

        public EnumCountry OriginCountry { get; set; }

        public string? UrlPhoto { get; set; }
    }
}