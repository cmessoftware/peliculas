using Peliculas.Web.ViewModels;
using Peliculas.Entidades;
using Peliculas.Web.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public interface IServicioFunciones : IServicioGenerico<Funcion>
    {
        Task<bool> Create(Funcion funcion);

        Task<List<Funcion>> GetAll();

        Task<Funcion> GetById(int? id);

        Task<bool> Update(Funcion funcion);

        Task<bool> Delete(int? id);

        Task<bool> DeleteConfirmed(int? id);
    }
}
