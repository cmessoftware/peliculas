using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios.CineOfertas
{
    public class RepositorioCineOfertas : RepositorioGenerico<CinemaOffer>, IRepositorioCineOfertas
    {
        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioCineOfertas(ILogger<RepositorioCineOfertas> logger, MovieDbContext context) : base(logger,
                                                                                                               context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(CinemaOffer entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

      
        public Task<List<CinemaOffer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CinemaOffer> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(CinemaOffer entity)
        {
            throw new NotImplementedException();
        }
    }
}