using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Web.Servicios.Generos
{
    public interface IServicioGeneros
    {
        Task<bool> Create(GeneroDto genero);

        Task<List<GeneroDto>> GetAll();

        Task<GeneroDto> GetById(int id);

        Task<bool> Update(GeneroDto genero);

        Task<bool> Delete(int id);
    }
}
