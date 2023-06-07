using Peliculas.WebApi.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Data;

namespace Peliculas.Data.Repositorios.Funciones
{
    public class RepositorioFunciones : RepositorioGenerico<Funcion>, IRepositorioFunciones
    {
        private readonly PeliculasDbContext _context;

        public RepositorioFunciones(PeliculasDbContext context) : base(context)
        {
            this._context = context;
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