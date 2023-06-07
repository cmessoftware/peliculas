using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Data.Repositorios
{
    public interface IUserRepository : IRepositorioGenerico<User>
    {
        Task<User> GetByUserName(string username);
    }
}