using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios.Cines
{
    public class RepositorioCines : RepositorioGenerico<Cine>, IRepositorioCines
    {

        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioCines(ILogger<RepositorioCines> logger, PeliculasContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(Cine entity)
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

        public Task<List<Cine>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Cine> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Cine entity)
        {
            throw new NotImplementedException();
        }
    }
}