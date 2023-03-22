using AutoMapper;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Peliculas.Data;
using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Repositorio
{
    public class RepositorioPelicula : RepositorioBase, IRepositorioPelicula
    {
        public RepositorioPelicula(PeliculasDbContext context,
                                   ILogger<RepositorioBase> logger) 
            : base(context, logger)
        {
        }

        public async Task<Pelicula> GetPeliculaEstrenoById(int id)
        {
            var pelicula = await GetByIdAsync(id);
            
            return pelicula;
        }

        public void ActualizarComentarioLike(Comentario? comentario, 
                                             string idLike)
        { 


        }
        public async Task<List<Pelicula>> GetPeliculasEstreno()
        {
            //Mala práctica traer todo y filtrar en memoria.
            var peliculas = await Get();
            //Definimos que las peliculas estrenos son la de este mes.
            peliculas = peliculas.Where(x => x.FechaEstreno.Month == DateTime.Now.Month).ToList();

            return peliculas;

        }
        public async Task<EntityEntry<Pelicula>> InsertarPelicula(Pelicula pelicula)
        {
            var entityEntry = await Insert(pelicula);

            await SaveChangesAsync();
        
            return entityEntry;
        }

    }
}
