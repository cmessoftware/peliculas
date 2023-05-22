using Microsoft.EntityFrameworkCore;
using Peliculas.Entidades;
using Peliculas.UnitOfWorks;

namespace Peliculas.Data.Repositorios.Generos
{
    public class RepositorioGeneros : RepositorioGenerico<Pelicula>, IRepositorioGeneros
    {
        private readonly PeliculasDbContext _context;
        public RepositorioGeneros(PeliculasDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> Create(Genero entity)
        {
            await _context.Generos.AddAsync(entity);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<bool> Delete(int? id)
        {

            var genero = await _context.Generos.FindAsync(id);

            if (genero == null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> DeleteConfirmed(int? id)
        {
            Genero? genero = _context.Generos.Find(id);

            if (genero != null)
            {
                _context.Generos.Remove(genero);
            }

            return true;
        }

        public async Task<List<Genero>> GetAll()
        {
            return await _context.Generos.ToListAsync();
        }

        public new async Task<Genero> GetById(int? id)
        {
            var genero = await _context.Generos.FindAsync(id);
            return genero;
        }

        public async Task<bool> Update(Genero entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}