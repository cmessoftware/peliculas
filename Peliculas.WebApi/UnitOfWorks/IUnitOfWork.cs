using Peliculas.Data.Repositorios;
using Peliculas.Data.Repositorios.Actores;
using Peliculas.Data.Repositorios.CineOfertas;
using Peliculas.Data.Repositorios.Cines;
using Peliculas.Data.Repositorios.Clientes;
using Peliculas.Data.Repositorios.Criticas;
using Peliculas.Data.Repositorios.Entradas;
using Peliculas.Data.Repositorios.Funciones;
using Peliculas.Repositorio.Peliculas;

namespace Peliculas.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IRepositorioPeliculas Peliculas { get; }
        IRepositorioComentarios Comentarios { get; }
        IRepositorioCriticas Criticas { get; }
        IRepositorioActores Actores { get; }
        IRepositorioCines Cines { get; }
        IRepositorioClientes Clientes { get; }
        IRepositorioCineOfertas CineOfertas { get; }
        IRepositorioEntradas Entradas { get; }
        IRepositorioFunciones Funciones { get; }
        IRepositorioGeneros Generos { get; }
        //IRepositorioPeliculaActores PeliculasActores { get; }
        IRepositorioSalasCine SalasDeCine { get; }
        IRepositorioUbicacionesEnSala UbicacionesEnSala { get; }
        IUserRepository Usuarios { get; }
        IUserLoginRepository UserLogin { get; }

        int SaveChanges();
    }
}