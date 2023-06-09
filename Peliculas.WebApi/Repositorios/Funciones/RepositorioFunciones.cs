using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios.Funciones
{
    public class RepositorioFunciones : RepositorioGenerico<Funcion>, IRepositorioFunciones
    {
        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioFunciones(ILogger<RepositorioFunciones> logger, PeliculasContext context) : base(logger,
                                                                                                           context)
        {
            _logger = logger;
            _context = context;
        }

        public Task<bool> Create(Funcion entity)
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

        public Task<List<Funcion>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Funcion> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Funcion entity)
        {
            throw new NotImplementedException();
        }
    }
}