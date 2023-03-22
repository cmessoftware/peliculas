using Microsoft.EntityFrameworkCore.ChangeTracking;
using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Repositorio
{
    public interface IRepositorioPelicula
    {
        void ActualizarComentarioLike(Comentario? comentario, string idLike);
        public Task<Pelicula> GetPeliculaEstrenoById(int id);
        public Task<List<Pelicula>> GetPeliculasEstreno();
        public Task<EntityEntry<Pelicula>> InsertarPelicula(Pelicula pelicula)
;
    }
}