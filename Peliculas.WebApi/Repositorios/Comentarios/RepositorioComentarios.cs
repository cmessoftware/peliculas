using Peliculas.Repositorio.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios.Generos
{
    public class RepositorioComentarios : RepositorioGenerico<Comentario>, IRepositorioComentarios
    {
        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioComentarios(ILogger<RepositorioComentarios> logger, PeliculasContext context) : base(logger,
                                                                                                               context)
        {
            this._logger = logger;
            this._context = context;
        }

        public new async Task<bool> Create(Comentario entity)
        {
            return await base.Create(entity);
        }

        public new async Task<bool> Delete(int? id)
        {
            return await base.Delete(id);
        }


        public new async Task<List<Comentario>> GetAll()
        {
            return await base.GetAll();
        }

        public new async Task<Comentario> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public new async Task<bool> Update(Comentario entity)
        {
            return await base.Update(entity);
        }
    }
}