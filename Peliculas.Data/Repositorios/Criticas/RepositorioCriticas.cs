using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Data.Repositorios.Criticas
{
    public class RepositorioCriticas : RepositorioGenerico<Critica> IRepositorioCriticas
    {
        private readonly PeliculasDbContext _context;

        public RepositorioCriticas(PeliculasDbContext context) : base(context)
        {
            this._context = context;
        }


        public Task<bool> Create(Critica entity)
        {
            
        }

        public Task<bool> Delete(Critica entity)
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

        public Task<List<Critica>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Critica> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Critica entity)
        {
            throw new NotImplementedException();
        }
    }
}