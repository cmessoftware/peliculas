using Microsoft.AspNetCore.Identity;
using Movies.WebApi.Dto.Account;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Mappers
{
    public interface IUserMapper : IGenericMapper<User, IdentityUser>
    {
       
    }
}