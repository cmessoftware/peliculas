using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Data;

namespace Peliculas.Data.Repositorios.Clientes
{
    public class RepositorioClientes : RepositorioGenerico<Cliente>, IRepositorioClientes
    {

        private readonly PeliculasDbContext _context;

        public RepositorioClientes(PeliculasDbContext context) : base(context)
        {
            this._context = context;
        }
        public Task<bool> Create(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cliente>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}