using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public interface IUserService : IServicioGenerico<User>
    {
        Task<bool> Create(User usuario);

        Task<List<User>> GetAll();

        Task<User> GetById(int? id);

        Task<bool> Update(User usuario);

        Task<bool> Delete(int? id);
        Task<User> GetByUserName(string username);
    }
}
