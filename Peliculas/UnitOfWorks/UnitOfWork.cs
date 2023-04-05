using Peliculas.Data;
using Peliculas.Repositorio.Peliculas;

namespace Peliculas.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PeliculasDbContext _context;
        public IRepositorioPeliculas Peliculas { get; }
        //public IRepositorioComentarios Comentarios { get; }

        public UnitOfWork(PeliculasDbContext context,
                          IRepositorioPeliculas peliculasRepo
                          /*IRepositorioComentarios comentariosRepo*/)
        {
            _context = context;
            Peliculas = peliculasRepo;
            //Comentarios = comentariosRepo;
        }

        public int SaveChanges()
        {
            return 0;
        }

    }
}