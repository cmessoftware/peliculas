using System.Security.Permissions;

namespace Peliculas.Entidades
{
    public class ActorPeliculaRel
    {
        public int Id { get; set; }

        public int ActorId { get; set; }

        public int PeliculaID { get; set; }

        public bool EsPrincipal { get; set; }
    }
}