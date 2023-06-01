namespace Peliculas.UnitOfWorks
{
    public interface IRepositorioGenerico<T> where T : class
    {
        Task<T> GetById(int? id);
        Task<List<T>> GetAll();
        Task<bool> Create(T entity);
        Task<bool> Delete(int? id);
        Task<bool> Update(T entity);
    }
}
