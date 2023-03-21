using Peliculas.Entidades;

namespace Peliculas.Repositorio
{
    public class RepositorioPelicula : IRepositorioPelicula
    {
        public Pelicula GetPeliculaEstrenoById(int id)
        {
            var pelicula = new Pelicula();


            return pelicula;
        }

        public void ActualizarComentarioLike(Comentario? comentario, string idLike)
        { }
        public List<Pelicula> GetPeliculasEstreno()
        {
            List<Pelicula> peliculas = new List<Pelicula>();



            return peliculas;

        }
        public void InsertarPelicula(Pelicula pelicula)
        { }

    }
}
