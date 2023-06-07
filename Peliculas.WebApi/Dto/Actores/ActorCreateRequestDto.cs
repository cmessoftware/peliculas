using Peliculas.Data;

namespace Peliculas.WebApi.Dto.Actores
{
    public class ActorCreateRequestDto
    {


        public string Nombre { get; set; }

        public int Edad { get; set; }

        public EnumPais Pais { get; set; }
    }
}