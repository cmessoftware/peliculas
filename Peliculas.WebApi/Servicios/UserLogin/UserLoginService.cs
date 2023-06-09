using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Servicios
{
    public class UserLoginService : IUserLoginService
    {
        public IUnitOfWork _unitOfWork;

        public UserLoginService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Create(UserLogin usuario)
        {
            if (usuario != null)
            {
                await _unitOfWork.UserLogin.Create(usuario);

                var result = _unitOfWork.SaveChanges();

                return result > 0 ? true : false;
            }
            return false;
        }

        public async Task<bool> Delete(int? id)
        {
            if (id != null)
            {
                await _unitOfWork.UserLogin.Delete(id);
            }
            return false;
        }

        public async Task<List<UserLogin>> GetAll()
        {
            var userLogin = await _unitOfWork.UserLogin.GetAll();
            return userLogin;
        }

        public async Task<UserLogin> GetById(int? id)
        {
            if (id != null)
            {
                var userLogin = await _unitOfWork.UserLogin.GetById(id);
                if (userLogin != null)
                {
                    return userLogin;
                }
            }
            return null;
        }

        public async Task<UserLogin> GetUserLogin(UserLogin user)
        {
            if (user != null)
            {
                var userLogin = await _unitOfWork.UserLogin.GetUserLogin(user);
                if (userLogin != null)
                {
                    return userLogin;
                }
            }
            return null;
        }

        public async Task<bool> Update(UserLogin usuario)
        {
            if (usuario != null)
            {
                var userServiceDB = await _unitOfWork.UserLogin.GetById(usuario.Id);
                if (userServiceDB != null)
                {
                    //comentarioDB.Contenido = UserService.Contenido;
                    //comentarioDB.Usuario = UserService.Usuario;

                    await _unitOfWork.UserLogin.Update(userServiceDB);

                    var result = _unitOfWork.SaveChanges();

                    return result > 0;
                }
            }
            return false;
        }
    }
}
