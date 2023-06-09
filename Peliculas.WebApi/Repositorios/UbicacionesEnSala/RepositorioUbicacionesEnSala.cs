using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios
{
    public class RepositorioUbicacionesEnSala : RepositorioGenerico<UbicacionesEnSala>, IRepositorioUbicacionesEnSala
    {

        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioUbicacionesEnSala(ILogger<RepositorioUbicacionesEnSala> logger, PeliculasContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
            this._context = context;
        }

        public Task<bool> Create(UbicacionesEnSala entity)
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

        public Task<List<UbicacionesEnSala>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UbicacionesEnSala> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(UbicacionesEnSala entity)
        {
            throw new NotImplementedException();
        }
    }
}