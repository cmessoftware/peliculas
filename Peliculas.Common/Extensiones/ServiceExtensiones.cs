using Microsoft.Extensions.DependencyInjection;
using Peliculas.Data.Repositorios.Actores;
using Peliculas.Data.Repositorios.CineOfertas;
using Peliculas.Data.Repositorios.Cines;
using Peliculas.Data.Repositorios.Clientes;
using Peliculas.Data.Repositorios.Criticas;
using Peliculas.Data.Repositorios.Entradas;
using Peliculas.Data.Repositorios.Funciones;
using Peliculas.Data.Repositorios.Generos;
using Peliculas.Data.Repositorios.SalasCine;
using Peliculas.Data.Repositorios.UbicacionesEnSala;
using Peliculas.Repositorio.Peliculas;
using Peliculas.Servicios;
using Peliculas.Servicios.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.Web.Mapeos;
using Peliculas.WebApi.Controllers;

namespace Peliculas.Common.Extensiones
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
            services.AddScoped<IServicioComentarios, ServicioComentarios>();
            services.AddScoped<IServicioCriticas, ServicioCriticas>();

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
            services.AddScoped<IComentariosMapper, ComentariosMapper>();
            services.AddScoped<ICriticasMapper, CriticasMapper>();


        }

        public static string JoinString<T>(this IEnumerable<T> source, string delimiter, Func<T, string> func)
        {
            return String.Join(delimiter, source.Select(func).ToArray());
        }
    }
}
