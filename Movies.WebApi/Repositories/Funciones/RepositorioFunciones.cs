using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios.Funciones
{
    public class RepositorioFunciones : RepositorioGenerico<Function>, IRepositorioFunciones
    {
        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioFunciones(ILogger<RepositorioFunciones> logger, MovieDbContext context) : base(logger,
                                                                                                           context)
        {
            _logger = logger;
            _context = context;
        }

        public Task<bool> Create(Function entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Function>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Function> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Function entity)
        {
            throw new NotImplementedException();
        }
    }
}