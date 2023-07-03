using Movies.Common.Helpers;
using Movies.Data.Repositorios;
using Movies.Data.Repositorios.Actores;
using Movies.Data.Repositorios.CineOfertas;
using Movies.Data.Repositorios.Cines;
using Movies.Data.Repositorios.Clientes;
using Movies.Data.Repositorios.Criticas;
using Movies.Data.Repositorios.Entradas;
using Movies.Data.Repositorios.Funciones;
using Movies.Data.Repositorios.Generos;
using Movies.Repositorio.Peliculas;
using Movies.Servicios;
using Movies.Servicios.Peliculas;
using Movies.UnitOfWorks;
using Movies.Web.Mapeos;
using Movies.WebApi.Authorization;
using Movies.WebApi.Controllers;
using Movies.WebApi.Mappers;


namespace Movies.Common.Extensions
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
            
            //Inyección de dependencias de mapeos.
            services.AddScoped<IGeneroMapper, GeneroMapper>();
            services.AddScoped<ICriticaMapper, CriticaMapper>();
            services.AddScoped<IComentarioMapper, ComentarioMapper>();
            services.AddScoped<IActorMapper, ActorMapper>();
            services.AddScoped<IMovieMapper, MovieMapper>();
            services.AddScoped<IUserMapper, UserMapper>();
            services.AddScoped<IRoleMapper, RoleMapper>();

            //Inyeccion de dependencias para configuracion de seguridad.
            services.AddScoped<ITokenConfigManager, TokenConfigManager>();
            services.AddScoped<ITokenManager, TokenManager>();
            services.AddScoped<IJwtUtils, JwtUtils>();


        }

        public static string JoinString<T>(this IEnumerable<T> source, string delimiter, Func<T, string> func)
        {
            return string.Join(delimiter, source.Select(func).ToArray());
        }
    }
}
