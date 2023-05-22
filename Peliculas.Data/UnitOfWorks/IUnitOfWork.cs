using Peliculas.Data.Repositorios.Actores;
using Peliculas.Data.Repositorios.CineOfertas;
using Peliculas.Data.Repositorios.Cines;
using Peliculas.Data.Repositorios.Clientes;
using Peliculas.Data.Repositorios.Criticas;
using Peliculas.Data.Repositorios.Entradas;
using Peliculas.Data.Repositorios.Funciones;
using Peliculas.Data.Repositorios.Generos;
using Peliculas.Data.Repositorios.PeliculasActores;
//using Peliculas.Data.Repositorios.PeliculasActores;
using Peliculas.Data.Repositorios.SalasCine;
using Peliculas.Data.Repositorios.UbicacionesEnSala;
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
        IRepositorioSalasDeCine SalasDeCine { get; }
        IRepositorioUbicacionesEnSala UbicacionesEnSala { get; }
        IRepositorioPeliculaActores PeliculasActores { get; }

        int SaveChanges();
    }
}