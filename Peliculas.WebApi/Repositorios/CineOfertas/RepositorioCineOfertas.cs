using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios.CineOfertas
{
    public class RepositorioCineOfertas : RepositorioGenerico<CineOferta>, IRepositorioCineOfertas
    {
        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioCineOfertas(ILogger<RepositorioCineOfertas> logger, PeliculasContext context) : base(logger,
                                                                                                               context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(CineOferta entity)
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

        public Task<List<CineOferta>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CineOferta> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(CineOferta entity)
        {
            throw new NotImplementedException();
        }
    }
}