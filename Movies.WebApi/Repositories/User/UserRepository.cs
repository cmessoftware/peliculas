using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios
{
    public class UserRepository : RepositorioGenerico<User>, IUserRepository
    {
        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public UserRepository(ILogger<UserRepository> logger, 
                              MovieDbContext context) : base(logger,
                                                                                     context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<bool> Create(User entity)
        {
            //return await base.Create(entity);
            //Use the Microsoft.AspNetCore.Idetity.EntityFrameworkCore api
            return  await base.Create(entity);
        }

        public async Task<bool> Delete(int? id)
        {
            return await base.Delete(id);
        }


        public async Task<List<User>> GetAll()
        {
            var users = await _context.Users.Include(e => e.Roles).ToListAsync();
    
            return users;
        }

        public async Task<User> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public async Task<User> GetByUserName(string username)
        {
            var user = await _context.Users.Include(e => e.Roles).
                                SingleOrDefaultAsync(x => x.UserName == username);

            return user;
        }

        public async Task<bool> Update(User entity)
        {
            return await base.Update(entity);
        }
    }
}