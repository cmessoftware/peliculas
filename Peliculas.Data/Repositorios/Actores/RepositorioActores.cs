using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Data.Repositorios.Actores
{
    public class RepositorioActores : RepositorioGenerico<Actor>, IRepositorioActores
    {
        private readonly PeliculasDbContext _context;

        public RepositorioActores(PeliculasDbContext context) : base(context)
        {
            this._context = context;
        }

        public Task<bool> Create(Actor entity)
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

        public Task<List<Actor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Actor> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Actor entity)
        {
            throw new NotImplementedException();
        }
    }
}