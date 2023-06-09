using Peliculas.Data.Repositorios;
using Peliculas.Data.Repositorios.Actores;
using Peliculas.Data.Repositorios.CineOfertas;
using Peliculas.Data.Repositorios.Cines;
using Peliculas.Data.Repositorios.Clientes;
using Peliculas.Data.Repositorios.Criticas;
using Peliculas.Data.Repositorios.Entradas;
using Peliculas.Data.Repositorios.Funciones;
using Peliculas.Repositorio.Peliculas;
using Peliculas.WebApi.Entidades;

namespace Peliculas.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PeliculasContext _context;
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
        public IUserRepository Usuarios { get; }
        public IUserLoginRepository UserLogin { get; }
        public IRepositorioEntradas Entradas { get; }
        public IRepositorioSalasCine SalasDeCine { get; }
        public IRepositorioUbicacionesEnSala UbicacionesEnSala { get; }

        public UnitOfWork(PeliculasContext context,
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
                          IUserRepository usuarios,
                          IUserLoginRepository userLogin)
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
            Usuarios = usuarios;
            UserLogin = userLogin;
            UbicacionesEnSala = ubicacionEnSalaRepo;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

    }
}