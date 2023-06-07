using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public interface IServicioSalasCine : IServicioGenerico<SalasCine>
    {
        Task<bool> Create(SalasCine salaCine);

        Task<List<SalasCine>> GetAll();

        Task<SalasCine> GetById(int? id);

        Task<bool> Update(SalasCine salaCine);

        Task<bool> Delete(SalasCine salaCine);
    }
}
