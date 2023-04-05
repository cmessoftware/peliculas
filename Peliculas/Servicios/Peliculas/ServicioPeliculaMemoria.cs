using Peliculas.Data;
using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Servicios.Peliculas
{
    public class ServicioPeliculaMemoria : IServicioPelicula
    {
        public Task<bool> Create(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(PeliculaDto pelicula)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pelicula>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Pelicula> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(PeliculaDto pelicula)
        {
            throw new NotImplementedException();
        }

        Task<List<PeliculaDto>> IServicioPelicula.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<PeliculaDto> IServicioPelicula.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}