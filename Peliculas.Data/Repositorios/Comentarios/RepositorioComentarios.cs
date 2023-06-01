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

        public new async Task<bool> Create(Comentario entity)
        {
            return await base.Create(entity);
        }

        public new async Task<bool> Delete(int? id)
        {
            return await base.Delete(id);
        }


        public new async Task<List<Comentario>> GetAll()
        {
            return await base.GetAll();
        }

        public new async Task<Comentario> GetById(int? id)
        {
            return await base.GetById(id);
        }

        public new async Task<bool> Update(Comentario entity)
        {
            return await base.Update(entity);
        }
    }
}