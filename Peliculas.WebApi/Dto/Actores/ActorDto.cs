using Peliculas.Data;

namespace Peliculas.WebApi.Dto
{
    public class ActorDto
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Biografia { get; set; }

        public EnumPais PaisOrigen { get; set; }

        public string? FotoUrl { get; set; }
    }
}