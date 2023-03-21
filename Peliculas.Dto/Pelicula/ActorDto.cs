using Peliculas.Data;

namespace Peliculas.Dto.DTOs
{
    public class ActorDto
    {

        public int Id { get; set; }

        public ActorPeliculaRelDto ActorPeliculaRel { get; set; }
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public EnumPais Pais { get; set; }
    }
}