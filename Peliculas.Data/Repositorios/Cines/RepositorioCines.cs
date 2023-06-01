using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Data.Repositorios.Cines
{
    public class RepositorioCines : RepositorioGenerico<Cine>, IRepositorioCines
    {
    
        public RepositorioCines(PeliculasDbContext context): base(context) 
        {
        }
        public Task<bool> Create(Cine entity)
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

        public Task<List<Cine>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Cine> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Cine entity)
        {
            throw new NotImplementedException();
        }
    }
}