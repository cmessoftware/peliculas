using System.Security.Permissions;

namespace Peliculas.Entidades
{
    public class ActorPeliculaRel
    {
        public int Id { get; set; }

        public Actor Actor { get; set; }

        public Pelicula Pelicula { get; set; }

        public bool EsPrincipal { get; set; }
    }
}