using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios
{
    public class RepositorioSalasCine : RepositorioGenerico<SalasCine>, IRepositorioSalasCine
    {
        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioSalasCine(ILogger<RepositorioSalasCine> logger, PeliculasContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(SalasCine entity)
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

        public Task<List<SalasCine>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SalasCine> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(SalasCine entity)
        {
            throw new NotImplementedException();
        }
    }
}