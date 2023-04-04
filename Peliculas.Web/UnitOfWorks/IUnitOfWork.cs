using Peliculas.Repositorio.Peliculas;
using Peliculas.Web.Repositorios.Generos;

namespace Peliculas.UnitOfWorks
{
    public interface IUnitOfWork 
    {
        IRepositorioPeliculas Peliculas { get; }
        IRepositorioComentarios Comentarios { get; }
        IRepositorioGeneros Generos { get; }

        int SaveChanges();
    }
}