using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public interface IServicioUbicacionesEnSala : IServicioGenerico<UbicacionesEnSala>
    {
        Task<bool> Create(UbicacionesEnSala ubicacionEnSala);

        Task<List<UbicacionesEnSala>> GetAll();

        Task<UbicacionesEnSala> GetById(int? id);

        Task<bool> Update(UbicacionesEnSala ubicacionEnSala);

        Task<bool> Delete(int? id);

        Task<bool> DeleteConfirmed(int? id);
    }
}
