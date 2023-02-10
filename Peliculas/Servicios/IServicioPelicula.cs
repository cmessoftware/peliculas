using Peliculas.DTOs;

namespace Peliculas.Servicios
{
    public interface IServicioPelicula
    {
        public PeliculaDto GetPeliculaEstrenoById(int id);
        public void ActualizarComentarioLike(ComentarioDto? comentario, string idLike);
        public List<PeliculaDto> GetPeliculasEstreno();
        public PeliculaDto CrearPelicula(PeliculaDto pelicula);
    }
}
