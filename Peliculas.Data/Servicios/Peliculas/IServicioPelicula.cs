using Peliculas.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.Web.Dto;

namespace Peliculas.Servicios.Peliculas
{
    public interface IServicioPelicula : IServicioGenerico<Pelicula>
    {
        Task<bool> Create(PeliculaDto pelicula);

        Task<List<PeliculaDto>> GetAll();

        Task<PeliculaDto> GetById(int? id);

        Task<bool> Update(PeliculaDto pelicula);

        Task<bool> Delete(int? id);
        Task<bool> DeleteConfirmed(int? id);

   
    }
}
