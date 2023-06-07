using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Data.Repositorios
{
    public interface IUserLoginRepository : IRepositorioGenerico<UserLogin>
    {
        Task<UserLogin> GetUserLogin(UserLogin userLogin);
    }
}