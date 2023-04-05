using Peliculas.Repositorio.Peliculas;

namespace Peliculas.UnitOfWorks
{
    public interface IUnitOfWork 
    {
        IRepositorioPeliculas Peliculas { get; }
        //IRepositorioComentarios Comentarios { get; }

        int SaveChanges();
    }
}