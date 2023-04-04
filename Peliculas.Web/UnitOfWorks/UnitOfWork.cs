using Peliculas.Data;
using Peliculas.Repositorio.Peliculas;
using Peliculas.Web.Repositorios.Genero;

namespace Peliculas.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PeliculasDbContext _context;
        public IRepositorioPeliculas Peliculas { get; }
        public IRepositorioComentarios Comentarios { get; }
        public IRepositorioGeneros Generos { get; }

        public UnitOfWork(PeliculasDbContext context,
                          IRepositorioPeliculas peliculasRepo,
                          IRepositorioComentarios comentariosRepo,
                          IRepositorioGeneros generosRepo)
        {
            _context = context;
            Peliculas = peliculasRepo;
            Comentarios = comentariosRepo;
            Generos = generosRepo;
        }

        public int SaveChanges()
        {
            return 0;
        }

        
    }
}