using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Data;
using Peliculas.Data.Repositorios.PeliculasActores;

namespace Peliculas.Data.Repositorios
{
    public class RepositorioPeliculaActores : RepositorioGenerico<PeliculasActores>, IRepositorioPeliculaActores
    {
        private readonly PeliculasDbContext _context;
        public RepositorioPeliculaActores(PeliculasDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<bool> Create(PeliculaActor entity)
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

        public Task<List<PeliculaActor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PeliculaActor> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(PeliculaActor entity)
        {
            throw new NotImplementedException();
        }
    }
}