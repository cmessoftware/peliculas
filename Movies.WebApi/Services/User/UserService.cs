using Microsoft.AspNetCore.Identity;
using Movies.UnitOfWorks;
using Movies.WebApi.Authorization;
using Movies.WebApi.Dto.Account;
using Movies.WebApi.Entities;
using Movies.WebApi.Helpers;
using Movies.WebApi.Mappers;

namespace Movies.Servicios
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IJwtUtils _jwtUtils;
        private readonly IRoleMapper _roleMapper;

        public UserService(IUnitOfWork unitOfWork,
                           IJwtUtils jwtUtils,
                           IRoleMapper roleMapper)
        {
            _unitOfWork = unitOfWork;
            _jwtUtils = jwtUtils;
            _roleMapper = roleMapper;
        }

        public async Task<AuthenticateResponseDto> Authenticate(AuthenticateRequestDto model)
        {
            var user = await _unitOfWork.Users.GetByUserName(model.Username);

            // validate
            if (user == null || !BCrypt.Net.BCrypt.Verify(
                model.Password, user.PasswordHash))
            {
                throw new AppException("Username or password is incorrect");
            }

            // authentication successful so generate jwt token
            var jwtToken = _jwtUtils.GenerateJwtToken(user);

            var authResponse = new AuthenticateResponseDto(_roleMapper);

            return authResponse.GetAuthenticateResponseDto(user, jwtToken);
        }

        public async Task<bool> Create(User user)
        {
            if (user != null)
            {
                return await _unitOfWork.Users.Create(user);
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                await _unitOfWork.Users.Delete(id);
            }
            return false;
        }

        public async Task<List<User>> GetAll()
        {
            var userService = await _unitOfWork.Users.GetAll();
            return userService;
        }

        public async Task<User> GetById(int? id)
        {
            if (id != null)
            {
                var userService = await _unitOfWork.Users.GetById(id);
                if (userService != null)
                {
                    return userService;
                }
            }
            return null;
        }

        public async Task<User> GetByUserName(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                var userService = await _unitOfWork.Users.GetByUserName(username);
                if (userService != null)
                {
                    return userService;
                }
            }
            return null;
        }

        public async Task<bool> Update(User usuario)
        {
            if (usuario != null)
            {
                var userServiceDB = await _unitOfWork.Users.GetById(usuario.Id);
                if (userServiceDB != null)
                {
                    //comentarioDB.Contenido = UserService.Contenido;
                    //comentarioDB.Usuario = UserService.Usuario;

                    await _unitOfWork.Users.Update(userServiceDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
