using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public class UserService : IUserService
    {
        public IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(User usuario)
        {
            if (usuario != null)
            {
                await _unitOfWork.Usuarios.Create(usuario);

                var result = _unitOfWork.SaveChanges();

                return result > 0;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                await _unitOfWork.Usuarios.Delete(id);
            }
            return false;
        }

        public async Task<List<User>> GetAll()
        {
            var userService = await _unitOfWork.Usuarios.GetAll();
            return userService;
        }

        public async Task<User> GetById(int? id)
        {
            if (id != null)
            {
                var userService = await _unitOfWork.Usuarios.GetById(id);
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
                var userService = await _unitOfWork.Usuarios.GetByUserName(username);
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
                var userServiceDB = await _unitOfWork.Usuarios.GetById(usuario.Id);
                if (userServiceDB != null)
                {
                    //comentarioDB.Contenido = UserService.Contenido;
                    //comentarioDB.Usuario = UserService.Usuario;

                    await _unitOfWork.Usuarios.Update(userServiceDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
