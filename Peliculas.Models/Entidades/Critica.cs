namespace Peliculas.Entidades
{
    public class Critica
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string Autor { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }

    }
}
