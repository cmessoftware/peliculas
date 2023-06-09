using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios
{
    public interface IUserLoginRepository : IRepositorioGenerico<UserLogin>
    {
        Task<UserLogin> GetUserLogin(UserLogin userLogin);
    }
}