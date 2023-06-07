using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Servicios
{
    public interface IUserLoginService : IServicioGenerico<UserLogin>
    {
        Task<bool> Create(UserLogin usuario);

        Task<List<UserLogin>> GetAll();

        Task<UserLogin> GetById(int? id);

        Task<bool> Update(UserLogin usuario);

        Task<bool> Delete(int? id);
        Task<UserLogin> GetUserLogin(UserLogin user);
    }
}
