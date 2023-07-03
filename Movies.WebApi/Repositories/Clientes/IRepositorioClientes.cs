using Microsoft.AspNetCore.Identity;
using Movies.UnitOfWorks;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios.Clientes
{
    public interface IRepositorioClientes : IRepositorioGenerico<IdentityUser>
    {
    }
}