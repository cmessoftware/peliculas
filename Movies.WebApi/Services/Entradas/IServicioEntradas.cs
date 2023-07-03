using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Servicios
{
    public interface IServicioEntradas : IServicioGenerico<Ticket>
    {
        Task<bool> Create(Ticket entrada);

       
    }
}
