using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Peliculas.Data;
using Peliculas.Entidades;
using System;

namespace Peliculas.Repositorio
{
    public class RepositorioBase : IRespositorioBase
    {
        private readonly PeliculasDbContext _context;
        private readonly ILogger<RepositorioBase> _logger;

        public RepositorioBase(PeliculasDbContext context,
                               ILogger<RepositorioBase> logger)
        {
            _context = context;
            _logger = logger;
        }


        public Task CreateAsync(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pelicula>> Get()
        {
            return await _context.Peliculas.ToListAsync();
        }

        public async Task<Pelicula> GetByIdAsync(int id)
        {
            return await _context.Peliculas.FirstOrDefaultAsync(x => x.Id == id);
            //return await _context.Peliculas.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<EntityEntry<Pelicula>> Insert(Pelicula pelicula)
        {
            return await _context.AddAsync(pelicula);
        }

        public EntityEntry<Pelicula> Update(Pelicula pelicula, params string[] parametros)
        {

            _context.Attach(pelicula);
            _context.Entry(pelicula).Property(p => p.Titulo).IsModified = true;

            return _context.Update(pelicula);
        }

    }
}
