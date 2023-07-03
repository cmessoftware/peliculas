using Microsoft.AspNetCore.Identity;
using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios
{
    public interface IUserRepository : IRepositorioGenerico<User>
    {
        Task<User> GetByUserName(string username);
    }
}