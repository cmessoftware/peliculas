using Peliculas.Web.ViewModels;
using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public interface IServicioGeneros : IServicioGenerico<Genero>
    {
        Task<bool> Create(Genero genero);

        Task<List<Genero>> GetAll();

        Task<Genero> GetById(int? id);

        Task<bool> Update(Genero genero);

        Task<bool> Delete(int? id);
    }
}
