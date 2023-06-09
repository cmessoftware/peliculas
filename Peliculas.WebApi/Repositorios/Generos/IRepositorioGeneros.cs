using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios
{
    public interface IRepositorioGeneros : IRepositorioGenerico<Genero>
    {
        Task<List<Genero>> GetAll(int? peliculaId);
        Task<Genero> GetById(int? id, int? peliculaId);
    }
}