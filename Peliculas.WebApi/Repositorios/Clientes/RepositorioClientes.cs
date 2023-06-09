using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios.Clientes
{
    public class RepositorioClientes : RepositorioGenerico<Cliente>, IRepositorioClientes
    {

        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioClientes(ILogger<RepositorioClientes> logger, PeliculasContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
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