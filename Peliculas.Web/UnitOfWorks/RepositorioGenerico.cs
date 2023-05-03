using Microsoft.EntityFrameworkCore;
using Peliculas.Data;

namespace Peliculas.UnitOfWorks
{
    public abstract class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        protected readonly PeliculasDbContext _context;

        protected RepositorioGenerico(PeliculasDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetById(int? id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<bool> Create(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);

            return true;
        }


        public async Task<bool> Delete(int? id)
        {

            var entity = await GetById(id);

            var enEntryRemove = _context.Set<TEntity>().Remove(entity);

            if (enEntryRemove.State == EntityState.Deleted)
                return true;
            else
                return false;
        }

        public async Task<bool> Update(TEntity entity)
        {
            var enEntry = _context.Set<TEntity>().Update(entity);

            if (enEntry.State == EntityState.Modified)
                return true;
            else
                return false;
           
        }

        public Task<bool> DeleteConfirmed(int? id)
        {
            throw new NotImplementedException();
        }
    }
}

