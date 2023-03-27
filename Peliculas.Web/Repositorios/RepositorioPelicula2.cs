using AutoMapper;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Peliculas.Data;
using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Repositorio
{
    public class RepositorioPelicula2 : RepositorioBase2<Pelicula>, IRepositorioPelicula2
    {
        private readonly PeliculasDbContext _context;

        //public async Task<Pelicula> GetPeliculaEstrenoById(int id)
        //{
        //    var pelicula = await GetByIdAsync(id);

        //    return pelicula;
        //}


        //public async Task<List<Pelicula>> GetPeliculasEstreno()
        //{
        //    //Mala práctica traer todo y filtrar en memoria.
        //    var peliculas = await Get();
        //    //Definimos que las peliculas estrenos son la de este mes.
        //    peliculas = peliculas.Where(x => x.FechaEstreno.Month == DateTime.Now.Month).ToList();

        //    return peliculas;

        //}
        //public async Task<EntityEntry<Pelicula>> InsertarPelicula(Pelicula pelicula)
        //{
        //    var entityEntry = await Insert(pelicula);

        //    await SaveChangesAsync();

        //    return entityEntry;
        //}

        public RepositorioPelicula2(PeliculasDbContext context)
            : base(context)
        {
            this._context = context;
        }

        public async Task<bool> Create(Pelicula pelicula)
        {
            if (pelicula != null)
            {

                await _context.Peliculas.AddAsync(pelicula);

                var result = await _context.SaveChangesAsync();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public Task<IEnumerable<Pelicula>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Pelicula> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteProduct(int id)
        {
            if (id > 0)
            {
                var productDetails = await _context.Peliculas.GetById(id);
                if (productDetails != null)
                {
                    _context.Peliculas.Delete(productDetails);
                    var result = _context.SaveChangesAsync();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}
