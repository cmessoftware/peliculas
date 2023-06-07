using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Data;

namespace Peliculas.Data.Repositorios.Entradas
{
    public class RepositorioEntradas : RepositorioGenerico<Entrada>, IRepositorioEntradas
    {
        private readonly PeliculasDbContext _context;

        public RepositorioEntradas(PeliculasDbContext context) : base(context)
        {
            this._context = context;
        }
        public Task<bool> Create(Entrada entity)
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

        public Task<List<Entrada>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Entrada> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Entrada entity)
        {
            throw new NotImplementedException();
        }
    }
}