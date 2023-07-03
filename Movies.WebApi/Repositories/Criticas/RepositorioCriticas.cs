using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios.Criticas
{
    public class RepositorioCriticas : RepositorioGenerico<Critics>, IRepositorioCriticas
    {

        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioCriticas(ILogger<RepositorioCriticas> logger, MovieDbContext context) : base(logger,
                                                                                                         context)
        {
            this._logger = logger;
            this._context = context;
        }


        public new async Task<bool> Create(Critics entity)
        {

            return await base.Create(entity);

        }

    
        public async Task<List<Critics>> GetAll()
        {
            return await base.GetAll();
        }

        public new async Task<Critics> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public async Task<bool> Update(Critics entity)
        {
            return await base.Update(entity);
        }
    }
}