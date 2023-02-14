using Peliculas.Entidades;

namespace Peliculas.Repositorio
{
    public interface IRepositorioPeliculas
    {
        public void ActualizarComentarioLike(Comentario? comentario, string idLike);
        public void CrearPelicula(Pelicula pelicula);
        public Pelicula GetPeliculaEstrenoById(int id);
        public List<Pelicula> GetPeliculasEstreno();
    }
}