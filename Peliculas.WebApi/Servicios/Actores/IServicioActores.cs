using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public interface IServicioActores : IServicioGenerico<Actor>
    {
        Task<bool> Create(Actor actor);

        Task<List<Actor>> GetAll();

        Task<Actor> GetById(int? id);

        Task<bool> Update(Actor actor);

        Task<bool> Delete(Actor actor);
    }
}
