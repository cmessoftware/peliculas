using Microsoft.Extensions.DependencyInjection;
using Peliculas.Common.Utils;
using Peliculas.Servicios;
using Peliculas.Servicios.Peliculas;

namespace Peliculas.Common.Extensiones
{
    public static class ServiceExtensiones
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            //Configuro inyección de dependencias del UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Configuro inyección de dependencias de los servicios

            services.AddScoped<IServicioPelicula, ServicioPelicula>();
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

            //Inyeccion de dependencias para configuracion de seguridad.
            services.AddScoped<ITokenConfigManager, TokenConfigManager>();
            services.AddScoped<ITokenManager, TokenManager>();


        }

        public static string JoinString<T>(this IEnumerable<T> source, string delimiter, Func<T, string> func)
        {
            return String.Join(delimiter, source.Select(func).ToArray());
        }
    }
}
