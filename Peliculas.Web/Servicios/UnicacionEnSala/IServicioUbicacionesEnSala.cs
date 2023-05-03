using Peliculas.UnitOfWorks;
using Peliculas.Web.Entidades;

namespace Peliculas.Servicios
{
    public interface IServicioUbicacionesEnSala : IServicioGenerico<UbicacionEnSala>
    {
        Task<bool> Create(UbicacionEnSala ubicacionEnSala);

        Task<List<UbicacionEnSala>> GetAll();

        Task<UbicacionEnSala> GetById(int? id);

        Task<bool> Update(UbicacionEnSala ubicacionEnSala);

        Task<bool> Delete(int? id);

        Task<bool> DeleteConfirmed(int? id);
    }
}
