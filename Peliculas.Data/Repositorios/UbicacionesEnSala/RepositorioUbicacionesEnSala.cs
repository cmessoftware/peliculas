using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Data.Repositorios.UbicacionesEnSala
{
    public class RepositorioUbicacionesEnSala : RepositorioGenerico<UbicacionEnSala>, IRepositorioUbicacionesEnSala
    {

        private readonly PeliculasDbContext _context;
        public RepositorioUbicacionesEnSala(PeliculasDbContext context) : base(context)
        {
            _context = context;
        }
        public Task<bool> Create(UbicacionEnSala entity)
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

        public Task<List<UbicacionEnSala>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UbicacionEnSala> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(UbicacionEnSala entity)
        {
            throw new NotImplementedException();
        }
    }
}