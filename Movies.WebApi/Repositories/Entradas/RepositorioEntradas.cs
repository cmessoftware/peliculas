using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios.Entradas
{
    public class RepositorioEntradas : RepositorioGenerico<Ticket>, IRepositorioEntradas
    {

        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioEntradas(ILogger<RepositorioEntradas> logger, MovieDbContext context) : base(logger,
                                                                                                         context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(Ticket entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

      
        public Task<List<Ticket>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Ticket entity)
        {
            throw new NotImplementedException();
        }
    }
}