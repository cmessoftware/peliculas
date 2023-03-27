using Peliculas.Repositorio.Peliculas;

namespace Peliculas.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositorioPeliculas Peliculas { get; }
        IRepositorioComentarios Comentarios { get; }


        int SaveChanges();
    }
}