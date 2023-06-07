using Microsoft.EntityFrameworkCore;
using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Data;

namespace Peliculas.Data.Repositorios
{
    public class UserRepository : RepositorioGenerico<User>, IUserRepository
    {
        private readonly PeliculasDbContext _context;

        public UserRepository(PeliculasDbContext context) : base(context)
        {
            this._context = context;
        }
        public async Task<bool> Create(User entity)
        {
            return await base.Create(entity);
        }

        public Task<bool> Delete(int? id)
        {
            return base.Delete(id);
        }


        public async Task<List<User>> GetAll()
        {
            return await base.GetAll();
        }

        public async Task<User> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public async Task<User> GetByUserName(string username)
        {
            var user = await (from usuario in _context.Set<User>()
                              join userLogin in _context.Set<UserLogin>()
                                on usuario.Id equals userLogin.UserId
                              where userLogin.UserName == username
                              select usuario).FirstOrDefaultAsync();

            return user;
        }

        public async Task<bool> Update(User entity)
        {
            return await base.Update(entity);
        }
    }
}