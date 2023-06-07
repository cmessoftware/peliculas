using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Data;

namespace Peliculas.Data.Repositorios
{
    public class RepositorioSalasCine : RepositorioGenerico<SalasCine>, IRepositorioSalasCine
    {
        private readonly PeliculasDbContext _context;
        public RepositorioSalasCine(PeliculasDbContext context) : base(context)
        {
            _context = context;
        }
        public Task<bool> Create(SalasCine entity)
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

        public Task<List<SalasCine>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SalasCine> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(SalasCine entity)
        {
            throw new NotImplementedException();
        }
    }
}