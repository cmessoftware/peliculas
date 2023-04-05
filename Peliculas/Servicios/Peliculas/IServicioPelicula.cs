using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Servicios.Peliculas
{
    public interface IServicioPelicula
    {
        Task<bool> Create(PeliculaDto pelicula);

        Task<List<PeliculaDto>> GetAll();

        Task<PeliculaDto> GetById(int id);

        Task<bool> Update(PeliculaDto pelicula);

        Task<bool> Delete(int id);
    }
}
