using Peliculas.Data;
using Peliculas.Web.Entidades;

namespace Peliculas.Entidades
{
    public class Pelicula
    {
      
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Estreno { get; set; }
        public EnumPais PaisOrigen { get; set; }
        public bool EnCartelera { get; set; }
        public string Resumen { get; set; }

        public string Director { get; set; }

        public string PosterLink { get; set; }

        public string TrailerLink { get; set; }

        public List<Actor> Actores { get; set; }
   
        public List<Comentario> Comentarios { get; set; }

        public List<Genero> Generos { get; set; }

        public List<Cine> Cines { get; set; }

        public List<Critica> Criticas { get; set; }

        public List<Funcion> Funciones { get; set; }
        
    }
}
