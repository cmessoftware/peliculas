using Microsoft.EntityFrameworkCore;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios
{
    public class UserLoginRepository : RepositorioGenerico<UserLogin>, IUserLoginRepository
    {
        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public UserLoginRepository(ILogger<UserLoginRepository> logger, PeliculasContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
            this._context = context;
        }
        public async Task<bool> Create(UserLogin entity)
        {
            return await base.Create(entity);
        }

        public Task<bool> Delete(int? id)
        {
            return base.Delete(id);
        }


        public async Task<List<UserLogin>> GetAll()
        {
            return await base.GetAll();
        }

        public async Task<UserLogin> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public async Task<UserLogin> GetUserLogin(UserLogin userLoging)
        {
            var user = await (from uLogin in _context.Set<UserLogin>()
                              where uLogin.UserName == userLoging.UserName
                              select uLogin).FirstOrDefaultAsync();

            return user;
        }

        public async Task<bool> Update(UserLogin entity)
        {
            return await base.Update(entity);
        }
    }
}