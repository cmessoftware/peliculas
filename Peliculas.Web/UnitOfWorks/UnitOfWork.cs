using Peliculas.Data;
using Peliculas.Repositorio.Peliculas;
using Peliculas.Web.Repositorios.Actores;
using Peliculas.Web.Repositorios.CineOfertas;
using Peliculas.Web.Repositorios.Cines;
using Peliculas.Web.Repositorios.Clientes;
using Peliculas.Web.Repositorios.Criticas;
using Peliculas.Web.Repositorios.Entradas;
using Peliculas.Web.Repositorios.Funciones;
using Peliculas.Web.Repositorios.Generos;
using Peliculas.Web.Repositorios.SalasCine;
using Peliculas.Web.Repositorios.UbicacionesEnSala;

namespace Peliculas.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PeliculasDbContext _context;
        public IRepositorioPeliculas Peliculas { get; }
        public IRepositorioComentarios Comentarios { get; }
        public IRepositorioActores Actores { get; }
        public IRepositorioCineOfertas CineOfertas { get; }
        public IRepositorioEntradas Entrada { get; }
        public IRepositorioFunciones Funciones { get; }
        public IRepositorioCines Cines { get; }
        public IRepositorioClientes Clientes { get; }
        //public IRepositorioPeliculaActores PeliculasActores { get; }
        public IRepositorioSalasDeCine SalaDeCine { get; }
        public IRepositorioUbicacionesEnSala UbicacionEnSala { get; }
        public IRepositorioGeneros Generos { get; }
        public IRepositorioCriticas Criticas { get; }
        public IRepositorioEntradas Entradas { get; }
        public IRepositorioSalasDeCine SalasDeCine { get; }
        public IRepositorioUbicacionesEnSala UbicacionesEnSala { get; }

        public UnitOfWork(PeliculasDbContext context,
                          IRepositorioPeliculas peliculasRepo,
                          IRepositorioComentarios comentariosRepo,
                          IRepositorioActores actoresRepo,
                          IRepositorioCineOfertas cineOfertasRepo,
                          IRepositorioEntradas entradaRepo,
                          IRepositorioFunciones funcionesRepo,
                          IRepositorioCines cinesRepo,
                          IRepositorioClientes clientesRepo, 
                          //IRepositorioPeliculaActores peliculasActoresRepo,
                          IRepositorioSalasDeCine salaDeCineRepo,
                          IRepositorioUbicacionesEnSala ubicacionEnSalaRepo, 
                          IRepositorioGeneros generosRepo,
                          IRepositorioCriticas criticasRepo)
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
            //PeliculasActores = peliculasActoresRepo;
            SalaDeCine = salaDeCineRepo;
            UbicacionEnSala = ubicacionEnSalaRepo;
            Generos = generosRepo;
            Criticas = criticasRepo;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

    }
}