using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Data;

namespace Peliculas.Data.Repositorios.CineOfertas
{
    public class RepositorioCineOfertas : RepositorioGenerico<CineOferta>, IRepositorioCineOfertas
    {
        private readonly PeliculasDbContext _context;

        public RepositorioCineOfertas(PeliculasDbContext context) : base(context)
        {
            this._context = context;
        }

        public Task<bool> Create(CineOferta entity)
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

        public Task<List<CineOferta>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CineOferta> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(CineOferta entity)
        {
            throw new NotImplementedException();
        }
    }
}