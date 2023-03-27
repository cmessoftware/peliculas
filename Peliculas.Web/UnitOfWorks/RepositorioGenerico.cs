using Microsoft.EntityFrameworkCore;
using Peliculas.Data;

namespace Peliculas.UnitOfWorks
{
    public abstract class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        protected readonly PeliculasDbContext _context;

        protected RepositorioGenerico(PeliculasDbContext context)
        {
            _context = context;
        }

        public async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }


        public async Task<bool> Delete(T entity)
        {
            return await Task.Run(() => {
                var enEntry = _context.Set<T>().Remove(entity);

                if (enEntry.State == EntityState.Deleted)
                    return true;
                else
                    return false;
            });
        }

        public async Task<bool> Update(T entity)
        {

            return await Task.Run( () => {
                    var enEntry = _context.Set<T>().Update(entity);

                    if (enEntry.State == EntityState.Modified)
                        return true;
                    else
                        return false;
            });
           
        }

    }
}

