using Peliculas.Entidades;

namespace Peliculas.Entidades
{
    public class Funcion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public List<Entrada> Entradas { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}
