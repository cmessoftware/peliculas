using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Servicios
{
    public interface IServicioPelicula
    {
        public PeliculaDto GetPeliculaEstrenoById(int id);
        public void ActualizarComentarioLike(ComentarioDto? comentario, string idLike);
        public List<PeliculaDto> GetPeliculasEstreno();
        public void InsertarPelicula(Pelicula pelicula);
    }
}
