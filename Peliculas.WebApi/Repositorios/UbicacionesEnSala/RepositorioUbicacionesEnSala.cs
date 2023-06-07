using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Data;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios
{
    public class RepositorioUbicacionesEnSala : RepositorioGenerico<UbicacionesEnSala>, IRepositorioUbicacionesEnSala
    {

        private readonly PeliculasDbContext _context;
        public RepositorioUbicacionesEnSala(PeliculasDbContext context) : base(context)
        {
            _context = context;
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