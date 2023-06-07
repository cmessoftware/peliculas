using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public interface IServicioCines : IServicioGenerico<Cine>
    {
        Task<bool> Create(Cine cine);

        Task<List<Cine>> GetAll();

        Task<Cine> GetById(int? id);

        Task<bool> Update(Cine cine);

        Task<bool> Delete(Cine cine);
    }
}
