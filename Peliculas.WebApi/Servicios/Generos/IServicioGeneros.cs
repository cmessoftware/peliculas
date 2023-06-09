using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public interface IServicioGeneros : IServicioGenerico<Genero>
    {
        Task<Genero> GetById(int? id, int? peliculaId);

    }
}
