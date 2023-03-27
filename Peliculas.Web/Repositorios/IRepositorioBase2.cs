using Microsoft.EntityFrameworkCore.ChangeTracking;
using Peliculas.Entidades;
using System.Security.Principal;

namespace Peliculas.Repositorio
{
    public interface IRepositorioBase2<TEntity> where TEntity : class
    {
        //CRUD

        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(int id);

        Task Create(TEntity entity);

        Task Update(int id, TEntity entity);

        Task Delete(int id);

    }
}