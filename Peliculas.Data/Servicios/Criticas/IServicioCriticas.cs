using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public interface IServicioCriticas : IServicioGenerico<Critica>
    {
        Task<bool> Create(Critica critica);

        Task<List<Critica>> GetAll();

        Task<Critica> GetById(int? id);

        Task<bool> Update(Critica critica);

        Task<bool> Delete(int? id);

        Task<bool> DeleteConfirmed(int? id);
    }
}
