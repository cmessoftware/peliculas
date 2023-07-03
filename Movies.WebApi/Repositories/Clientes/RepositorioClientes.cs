using Microsoft.AspNetCore.Identity;
using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios.Clientes
{
    public class RepositorioClientes : RepositorioGenerico<IdentityUser>, IRepositorioClientes
    {

        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioClientes(ILogger<RepositorioClientes> logger, 
                                   MovieDbContext context) : base(logger,context)
        {
            this._logger = logger;
            this._context = context;
        }
        public async Task<bool> Create(IdentityUser entity)
        {
            return await base.Create(entity);
        }

        public async Task<bool> Delete(int? id)
        {
            return await base.Delete(id);
        }

       
        public async Task<List<IdentityUser>> GetAll()
        {
            return await base.GetAll();
        }

        public async Task<IdentityUser> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public async Task<bool> Update(IdentityUser entity)
        {
            return await base.Update(entity);
        }
    }
}