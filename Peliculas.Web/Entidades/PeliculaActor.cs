using System.Security.Permissions;

namespace Peliculas.Entidades
{
    public class PeliculaActor
    {
        public int Id { get; set; }
        public string Personaje { get; set; }
        public bool EsPrincipal { get; set; }
        public int Orden { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}