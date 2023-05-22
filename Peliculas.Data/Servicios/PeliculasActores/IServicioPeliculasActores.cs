using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public interface IServicioPeliculasActores : IServicioGenerico<PeliculaActor>
    {
        Task<bool> Create(PeliculaActor peliculaActor);

        Task<List<PeliculaActor>> GetAll();

        Task<PeliculaActor> GetById(int? id);

        Task<bool> Update(PeliculaActor peliculaActor);

        Task<bool> Delete(int? id);
    }
}
