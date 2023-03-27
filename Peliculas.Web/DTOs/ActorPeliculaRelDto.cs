using Peliculas.Entidades;

using System.Security.Permissions;

namespace Peliculas.DTOs
{
    public class ActorPeliculaRelDto
    {
        public int Id { get; set; }
        
        public int PeliculaId { get; set; }

        public int ActorId { get; set; }
        public string Personaje { get; set; }

        public bool EsPrincipal { get; set; }
        
        public int Orden { get; set; }
        public Pelicula Pelicula { get; set; }
        public Actor Actor { get; set; }
    }
}