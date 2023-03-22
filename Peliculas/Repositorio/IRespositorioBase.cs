using Microsoft.EntityFrameworkCore.ChangeTracking;
using Peliculas.Entidades;

namespace Peliculas.Repositorio
{
    public interface IRespositorioBase
    {
        //CRUD

        public Task<List<Pelicula>> Get();

        public Task<Pelicula> GetByIdAsync(int id);

        public Task CreateAsync(Pelicula pelicula);

        public EntityEntry<Pelicula> Update(Pelicula pelicula, params string[] parametros)
;
        public Task DeleteAsync(int id);

        public Task SaveChangesAsync();

        public Task<EntityEntry<Pelicula>> Insert(Pelicula pelicula);



    }
}