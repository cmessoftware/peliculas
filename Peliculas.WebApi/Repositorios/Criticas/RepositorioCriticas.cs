using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios.Criticas
{
    public class RepositorioCriticas : RepositorioGenerico<Critica>, IRepositorioCriticas
    {

        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioCriticas(ILogger<RepositorioCriticas> logger, PeliculasContext context) : base(logger,
                                                                                                         context)
        {
            this._logger = logger;
            this._context = context;
        }


        public new async Task<bool> Create(Critica entity)
        {

            return await base.Create(entity);

        }

        public async Task<bool> DeleteConfirmed(int? id)
        {
            return await Delete(id);
        }

        public async Task<List<Critica>> GetAll()
        {
            return await base.GetAll();
        }

        public new async Task<Critica> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public async Task<bool> Update(Critica entity)
        {
            return await base.Update(entity);
        }
    }
}