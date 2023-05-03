using Peliculas.Repositorio.Peliculas;
using Peliculas.Web.Repositorios.Actores;
using Peliculas.Web.Repositorios.CineOfertas;
using Peliculas.Web.Repositorios.Cines;
using Peliculas.Web.Repositorios.Clientes;
using Peliculas.Web.Repositorios.Criticas;
using Peliculas.Web.Repositorios.Entradas;
using Peliculas.Web.Repositorios.Funciones;
using Peliculas.Web.Repositorios.Generos;
//using Peliculas.Web.Repositorios.PeliculasActores;
using Peliculas.Web.Repositorios.SalasCine;
using Peliculas.Web.Repositorios.UbicacionesEnSala;

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


        int SaveChanges();
    }
}