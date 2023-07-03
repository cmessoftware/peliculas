using Microsoft.AspNetCore.Identity;
using Movies.UnitOfWorks;
using Movies.WebApi.Dto.Account;
using Movies.WebApi.Entities;

namespace Movies.Servicios
{
    public interface IUserService : IServicioGenerico<User>
    {
        Task<AuthenticateResponseDto> Authenticate(AuthenticateRequestDto model);
    }
}
