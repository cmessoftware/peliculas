using Movies.Data.Repositorios;
using Movies.Data.Repositorios.Actores;
using Movies.Data.Repositorios.CineOfertas;
using Movies.Data.Repositorios.Cines;
using Movies.Data.Repositorios.Clientes;
using Movies.Data.Repositorios.Criticas;
using Movies.Data.Repositorios.Entradas;
using Movies.Data.Repositorios.Funciones;
using Movies.Repositorio.Peliculas;

namespace Movies.UnitOfWorks
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
        IRepositorioSalasCine SalasDeCine { get; }
        IRepositorioUbicacionesEnSala UbicacionesEnSala { get; }
        IUserRepository Users { get; }
  
        int SaveChanges();
    }
}