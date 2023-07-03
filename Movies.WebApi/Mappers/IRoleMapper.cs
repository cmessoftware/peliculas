using Movies.WebApi.Dto.Account;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Mappers
{
    public interface IRoleMapper
    {
        List<RoleDto>? Map(List<Role> roles);
    }
}