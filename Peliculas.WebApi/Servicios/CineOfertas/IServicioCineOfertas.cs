using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public interface IServicioCineOfertas : IServicioGenerico<CineOferta>
    {
        Task<bool> Create(CineOferta cineOfertas);

        Task<List<CineOferta>> GetAll();

        Task<CineOferta> GetById(int? id);

        Task<bool> Update(CineOferta cineOfertas);

        Task<bool> Delete(int? id);
    }
}
