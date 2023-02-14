using Microsoft.EntityFrameworkCore;
using Peliculas.Entidades;
using Peliculas.Entidades.Seeding;
using System.Reflection;

namespace Peliculas.Data
{
    public class PeliculasDbContext : DbContext
    {

        public PeliculasDbContext(DbContextOptions<PeliculasDbContext> options) :
            base(options)
        {}


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseInMemoryDatabase("Peliculas");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            SeedingModuloConsulta.Seed(modelBuilder);
        }


        //Reemplaza el valor por defecto que es datetime2.
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
        }


        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<CineOferta> CineOfertas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Critica> Criticas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<PeliculaActor> PeliculaActor { get; set; }
        public DbSet<SalaDeCine> SalasDeCine { get; set; }
        
    }
}