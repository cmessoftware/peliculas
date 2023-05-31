using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Data.Repositorios.SalasCine
{
    public class RepositorioSalasDeCine : RepositorioGenerico<SalaCine>, IRepositorioSalasDeCine
    {
        private readonly PeliculasDbContext _context;
        public RepositorioSalasDeCine(PeliculasDbContext context) : base(context)
        {
            _context = context;
        }
        public Task<bool> Create(SalaCine entity)
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

        public Task<List<SalaCine>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SalaCine> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(SalaCine entity)
        {
            throw new NotImplementedException();
        }
    }
}