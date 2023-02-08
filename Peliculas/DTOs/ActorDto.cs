namespace Peliculas.DTOs
{
    public class ActorDto
    {
        public int Id { get; set; }

        public ActorPeliculaRel ActorPeliculaRel { get; set; }
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Pais { get; set; }
        public bool EsPrincipal { get; internal set; }
    }
}