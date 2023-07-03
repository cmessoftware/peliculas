using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios
{
    public interface IRepositorioGeneros : IRepositorioGenerico<Gender>
    {
        Task<List<Gender>> GetAll(int? peliculaId);
        Task<Gender> GetById(int? id, int? peliculaId);
    }
}