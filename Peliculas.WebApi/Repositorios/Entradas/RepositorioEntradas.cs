using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios.Entradas
{
    public class RepositorioEntradas : RepositorioGenerico<Entrada>, IRepositorioEntradas
    {

        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioEntradas(ILogger<RepositorioEntradas> logger, PeliculasContext context) : base(logger,
                                                                                                         context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(Entrada entity)
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

        public Task<List<Entrada>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Entrada> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Entrada entity)
        {
            throw new NotImplementedException();
        }
    }
}