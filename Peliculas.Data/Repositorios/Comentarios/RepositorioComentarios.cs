using Microsoft.EntityFrameworkCore;
using Peliculas.Entidades;
using Peliculas.Repositorio.Peliculas;
using Peliculas.UnitOfWorks;

namespace Peliculas.Data.Repositorios.Generos
{
    public class RepositorioComentarios : RepositorioGenerico<Comentario>, IRepositorioComentarios
    {
        private readonly PeliculasDbContext _context;
        public RepositorioComentarios(PeliculasDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> Create(Comentario entity)
        {
            await _context.Comentarios.AddAsync(entity);
            await _context.SaveChangesAsync();

            return true;

        }

        public async Task<bool> Delete(int? id)
        {

            var genero = await _context.Comentarios.FindAsync(id);

            if (genero == null)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> DeleteConfirmed(int? id)
        {
            var response = _context.Comentarios.Find(id);

            if (response != null)
            {
                _context.Comentarios.Remove(response);
            }

            return true;
        }

        public async Task<List<Comentario>> GetAll()
        {
            return await _context.Comentarios.ToListAsync();
        }

        public new async Task<Comentario> GetById(int? id)
        {
            var response = await _context.Comentarios.FindAsync(id);
            return response;
        }

        public async Task<bool> Update(Comentario entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}