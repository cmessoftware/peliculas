using Peliculas.Data;
using Peliculas.DTOs;
using Peliculas.Entidades;
using System;

namespace Peliculas.Repositorio
{
    public class RepositorioPeliculas : IRepositorioPeliculas
    {
        private readonly PeliculasDbContext _dbPeliculas;

        public RepositorioPeliculas(PeliculasDbContext db)
        {
            _dbPeliculas = db;
        }
        public void ActualizarComentarioLike(Comentario? comentario, string idLike)
        {
            throw new NotImplementedException();
        }

        public void CrearPelicula(Pelicula pelicula)
        {
         
            _dbPeliculas.Peliculas.Add(pelicula);
            _dbPeliculas.SaveChanges();

        }

        public Pelicula GetPeliculaEstrenoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pelicula> GetPeliculasEstreno()
        {
            throw new NotImplementedException();
        }
    }
}
