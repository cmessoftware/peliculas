using Movies.Data.Repositorios;
using Movies.Data.Repositorios.Actores;
using Movies.Data.Repositorios.CineOfertas;
using Movies.Data.Repositorios.Cines;
using Movies.Data.Repositorios.Clientes;
using Movies.Data.Repositorios.Criticas;
using Movies.Data.Repositorios.Entradas;
using Movies.Data.Repositorios.Funciones;
using Movies.Repositorio.Peliculas;
using Movies.WebApi.Data;

namespace Movies.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieDbContext _context;
        public IRepositorioPeliculas Peliculas { get; }
        public IRepositorioComentarios Comentarios { get; }
        public IRepositorioActores Actores { get; }
        public IRepositorioCineOfertas CineOfertas { get; }
        public IRepositorioEntradas Entrada { get; }
        public IRepositorioFunciones Funciones { get; }
        public IRepositorioCines Cines { get; }
        public IRepositorioClientes Clientes { get; }
        //public IRepositorioPeliculaActores PeliculasActores { get; }
        public IRepositorioSalasCine SalaDeCine { get; }
        public IRepositorioGeneros Generos { get; }
        public IRepositorioCriticas Criticas { get; }
        public IUserRepository Users { get; }
        public IRepositorioEntradas Entradas { get; }
        public IRepositorioSalasCine SalasDeCine { get; }
        public IRepositorioUbicacionesEnSala UbicacionesEnSala { get; }

        public UnitOfWork(MovieDbContext context,
                          IRepositorioPeliculas peliculasRepo,
                          IRepositorioComentarios comentariosRepo,
                          IRepositorioActores actoresRepo,
                          IRepositorioCineOfertas cineOfertasRepo,
                          IRepositorioEntradas entradaRepo,
                          IRepositorioFunciones funcionesRepo,
                          IRepositorioCines cinesRepo,
                          IRepositorioClientes clientesRepo,
                          IRepositorioSalasCine salaDeCineRepo,
                          IRepositorioUbicacionesEnSala ubicacionEnSalaRepo,
                          IRepositorioGeneros generosRepo,
                          IRepositorioCriticas criticasRepo,
                          IUserRepository usuarios
                          )
        {
            _context = context;
            Peliculas = peliculasRepo;
            Comentarios = comentariosRepo;
            Actores = actoresRepo;
            CineOfertas = cineOfertasRepo;
            Entrada = entradaRepo;
            Funciones = funcionesRepo;
            Cines = cinesRepo;
            Clientes = clientesRepo;
            SalaDeCine = salaDeCineRepo;
            Generos = generosRepo;
            Criticas = criticasRepo;
            Users = usuarios;
            UbicacionesEnSala = ubicacionEnSalaRepo;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

    }
}