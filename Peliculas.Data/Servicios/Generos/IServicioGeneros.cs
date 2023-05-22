using Peliculas.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.Web.ViewModels;

namespace Peliculas.Servicios
{
    public interface IServicioGeneros : IServicioGenerico<Genero>
    {
        Task<Genero> GetById(int? id);
        Task<List<Genero>> GetAll();
        Task<bool> Create(Genero entity);
        Task<bool> Delete(int? id);
        Task<bool> DeleteConfirmed(int? id);
        Task<bool> Update(Genero entity);
    }
}
