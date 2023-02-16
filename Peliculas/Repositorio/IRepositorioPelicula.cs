using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Repositorio
{
    public interface IRepositorioPelicula
    {
        void ActualizarComentarioLike(ComentarioDto? comentario, string idLike);
        Pelicula GetPeliculaEstrenoById(int id);
        List<Pelicula> GetPeliculasEstreno();
        void InsertarPelicula(Pelicula pelicula);
    }
}