using NetTopologySuite.Geometries;

namespace Peliculas.Entidades
{
    public class Cine
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cadena { get; set; }

        public Point Ubicacion { get; set; }
        public List<SalaCine> SalasCine { get; set; }

        public List<CineOferta> CineOfertas { get; set; }

        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}