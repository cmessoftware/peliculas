using Peliculas.Data;

namespace Peliculas.Entidades
{
    public class Pelicula
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaEstreno { get; set; }
        public EnumPais PaisOrigen { get; set; }

        public string Resumen { get; set; }

        public string Director { get; set; }

        public string PosterLink { get; set; }

        public string TrailerLink { get; set; }

        public List<PeliculaActor> PeliculaActores { get; set; }

        public List<Comentario> Comentarios { get; set; }

        public List<Genero> Generos { get; set; }

        public List<SalaCine> SalasCines { get; set; }

        public List<Critica> Criticas { get; set; }
    }
}
