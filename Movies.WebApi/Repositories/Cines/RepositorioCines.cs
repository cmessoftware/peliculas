using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios.Cines
{
    public class RepositorioCines : RepositorioGenerico<Cinema>, IRepositorioCines
    {

        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioCines(ILogger<RepositorioCines> logger, MovieDbContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(Cinema entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cinema>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Cinema> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Cinema entity)
        {
            throw new NotImplementedException();
        }
    }
}