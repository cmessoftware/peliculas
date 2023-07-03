using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Servicios
{
    public interface IServicioGeneros : IServicioGenerico<Gender>
    {
        Task<Gender> GetById(int? id, int? peliculaId);

    }
}
