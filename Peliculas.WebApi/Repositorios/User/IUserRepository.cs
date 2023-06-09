using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios
{
    public interface IUserRepository : IRepositorioGenerico<User>
    {
        Task<User> GetByUserName(string username);
    }
}