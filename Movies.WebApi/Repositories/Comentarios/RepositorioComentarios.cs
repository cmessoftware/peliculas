using Movies.Repositorio.Peliculas;
using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios.Generos
{
    public class RepositorioComentarios : RepositorioGenerico<Comments>, IRepositorioComentarios
    {
        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioComentarios(ILogger<RepositorioComentarios> logger, MovieDbContext context) : base(logger,
                                                                                                               context)
        {
            this._logger = logger;
            this._context = context;
        }

        public new async Task<bool> Create(Comments entity)
        {
            return await base.Create(entity);
        }

        public new async Task<bool> Delete(int? id)
        {
            return await base.Delete(id);
        }


        public new async Task<List<Comments>> GetAll()
        {
            return await base.GetAll();
        }

        public new async Task<Comments> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public new async Task<bool> Update(Comments entity)
        {
            return await base.Update(entity);
        }
    }
}