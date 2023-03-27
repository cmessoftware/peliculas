using Microsoft.EntityFrameworkCore.ChangeTracking;
using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Repositorio
{
    public interface IRepositorioPelicula2
    {
        Task<bool> Create(Pelicula pelicula);

        Task<IEnumerable<Pelicula>> GetAll();

        Task<Pelicula> GetProductById(int id);

        Task<bool> UpdateProduct(Pelicula pelicula);

        Task<bool> DeleteProduct(int id);

    }
}