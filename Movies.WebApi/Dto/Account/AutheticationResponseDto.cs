using Microsoft.AspNetCore.Identity;
using Movies.WebApi.Entities;
using Movies.WebApi.Mappers;

namespace Movies.WebApi.Dto.Account
{
    public class AuthenticateResponseDto
    {
        private readonly IRoleMapper _roleMapper;
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public List<RoleDto> Roles { get; set; }
        public string Token { get; set; }

        public AuthenticateResponseDto(IRoleMapper roleMapper)
        {
            _roleMapper = roleMapper;
        }

        public AuthenticateResponseDto()
        {
        }

        public AuthenticateResponseDto GetAuthenticateResponseDto(User user, string token)
        {
            var auth = new AuthenticateResponseDto()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.UserName,
                Token = token
            };

             auth.Roles = _roleMapper.Map(user.Roles.Select(e => e).ToList());
      
             return auth;
        }
    }
}