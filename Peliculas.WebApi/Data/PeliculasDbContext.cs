using Microsoft.EntityFrameworkCore;
using Peliculas.WebApi.Entidades;
using System.Reflection;

namespace Peliculas.WebApi.Data
{
    public class PeliculasDbContext : DbContext
    {

        public PeliculasDbContext(DbContextOptions<PeliculasDbContext> options) :
            base(options)
        { }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseInMemoryDatabase("Peliculas");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //SeedingModuloConsulta.Seed(modelBuilder);
            //SeedingPeliculas.Seed(modelBuilder);
        }


        //Reemplaza el valor por defecto que es datetime2.
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }


        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<SalasCine> SalasCine { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<CineOferta> CineOfertas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Critica> Criticas { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Funcion> Funciones { get; set; }
        public DbSet<UbicacionesEnSala> UbicacionesEnSala { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }
        public DbSet<Direccion> Direccion { get; set; }

    }
}