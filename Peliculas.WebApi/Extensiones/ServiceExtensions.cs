using Peliculas.Common.Utils;
using Peliculas.Data.Repositorios;
using Peliculas.Data.Repositorios.Actores;
using Peliculas.Data.Repositorios.CineOfertas;
using Peliculas.Data.Repositorios.Cines;
using Peliculas.Data.Repositorios.Clientes;
using Peliculas.Data.Repositorios.Criticas;
using Peliculas.Data.Repositorios.Entradas;
using Peliculas.Data.Repositorios.Funciones;
using Peliculas.Data.Repositorios.Generos;
using Peliculas.Repositorio.Peliculas;
using Peliculas.Servicios;
using Peliculas.Servicios.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.Web.Mapeos;
using Peliculas.WebApi.Controllers;
using Peliculas.WebApi.Mapeos;


namespace Peliculas.Common.Extensiones
{
    public static class ServiceExtensions
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
            services.AddScoped<IUserLoginService, UserLoginService>();
            services.AddScoped<IUserService, UserService>();

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
            services.AddScoped<IRepositorioSalasCine, RepositorioSalasCine>();
            services.AddScoped<IRepositorioUbicacionesEnSala, RepositorioUbicacionesEnSala>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserLoginRepository, UserLoginRepository>();

            //Inyección de dependencias de mapeos.
            services.AddScoped<IGeneroMapper, GeneroMapper>();
            services.AddScoped<ICriticaMapper, CriticaMapper>();
            services.AddScoped<IComentarioMapper, ComentarioMapper>();
            services.AddScoped<IActorMapper, ActorMapper>();
            services.AddScoped<IPeliculaMapper, PeliculaMapper>();

            //Inyeccion de dependencias para configuracion de seguridad.
            services.AddScoped<ITokenConfigManager, TokenConfigManager>();
            services.AddScoped<ITokenManager, TokenManager>();


        }

        public static string JoinString<T>(this IEnumerable<T> source, string delimiter, Func<T, string> func)
        {
            return string.Join(delimiter, source.Select(func).ToArray());
        }
    }
}
