namespace Peliculas.UnitOfWorks
{
    public interface IRepositorioGenerico<T> where T : class
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task Create(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Update(T entity);
    }
}
