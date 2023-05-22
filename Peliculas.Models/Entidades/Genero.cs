namespace Peliculas.Entidades
{
    public class Genero
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Pelicula> Peliculas { get; set; }
    }
}