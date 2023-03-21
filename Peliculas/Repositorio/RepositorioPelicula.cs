using AutoMapper;

using Microsoft.EntityFrameworkCore;

using Peliculas.Data;
using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Repositorio
{
    public class RepositorioPelicula : IRepositorioPelicula
    {
        private readonly ILogger<RepositorioPelicula> _logger;

        private readonly PeliculasDbContext _context;

        public RepositorioPelicula(ILogger<RepositorioPelicula> logger, PeliculasDbContext context)
        {
            _logger = logger;
         
            _context = context;
        }
        public Pelicula GetPeliculaEstrenoById(int id)
        {
            var pelicula = new Pelicula();


            return pelicula;
        }

        public void ActualizarComentarioLike(ComentarioDto? comentario, string idLike)
        { 
        }
        public List<Pelicula> GetPeliculasEstreno()
        {
            List<Pelicula> peliculas = new List<Pelicula>();
           
            peliculas = _context.Peliculas.ToList();

            return peliculas;

        }
        public void InsertarPelicula(Pelicula pelicula)
        { }

    }
}
