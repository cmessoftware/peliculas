using Peliculas.Web.ViewModels;
using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public interface IServicioSalasCine : IServicioGenerico<SalaCine>
    {
        Task<bool> Create(SalaCine salaCine);

        Task<List<SalaCine>> GetAll();

        Task<SalaCine> GetById(int? id);

        Task<bool> Update(SalaCine salaCine);

        Task<bool> Delete(SalaCine salaCine);
    }
}
