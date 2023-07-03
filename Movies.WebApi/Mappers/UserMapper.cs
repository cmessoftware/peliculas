using Microsoft.AspNetCore.Identity;
using Movies.WebApi.Dto.Account;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Mappers
{
    internal class UserMapper : IUserMapper
    { 
        public List<User> Map(List<IdentityUser> entity)
        {
            throw new NotImplementedException();
        }
    }
}