using AutoMapper;
using Peliculas.Repositorio.Peliculas;
using Peliculas.Servicios;
using Peliculas.Servicios.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.Web.Mapeos;
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

namespace Peliculas.Extensiones
{
    public static class ServiceExtensiones
    {
        public static void AddServices(this IServiceCollection services)
        {
            //Configuro inyección de dependencias del UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Configuro inyección de dependencias de los servicios

            services.AddScoped<IServicioPelicula, ServicioPeliculaDB>();
            services.AddScoped<IServicioActores, ServicioActores>();
            services.AddScoped<IServicioGeneros, ServicioGeneros>();

            //Configuro inyección de dependencias de los repositorios
            services.AddScoped<IRepositorioPeliculas, RepositorioPeliculas>();
            services.AddScoped<IRepositorioGeneros, RepositorioGeneros>();
            services.AddScoped<IRepositorioCriticas, RepositorioCriticas>();
            services.AddScoped<IRepositorioComentarios, RepositorioComentarios>();
            services.AddScoped<IRepositorioActores, RepositorioActores>();
            services.AddScoped<IRepositorioCineOfertas, RepositorioCineOfertas>();
            services.AddScoped<IRepositorioCines, RepositorioCines>();
            services.AddScoped<IRepositorioFunciones, RepositorioFunciones>();
            services.AddScoped<IRepositorioEntradas, RepositorioEntradas>();
            services.AddScoped<IRepositorioClientes, RepositorioClientes>();
            services.AddScoped<IRepositorioSalasDeCine, RepositorioSalasDeCine>();
            services.AddScoped<IRepositorioUbicacionesEnSala, RepositorioUbicacionesEnSala>();

            //Inyección de dependencias de mapeos.
            services.AddScoped<IGenerosMapper, GenerosMapper>();


        }

        public static string JoinString<T>(this IEnumerable<T> source, string delimiter, Func<T, string> func)
        {
            return String.Join(delimiter, source.Select(func).ToArray());
        }
    }
}
