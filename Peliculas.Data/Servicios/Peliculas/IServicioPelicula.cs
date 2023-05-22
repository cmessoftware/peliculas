using Peliculas.Entidades;
using Peliculas.UnitOfWorks;
using Peliculas.Web.ViewModels;

namespace Peliculas.Servicios.Peliculas
{
    public interface IServicioPelicula : IServicioGenerico<Pelicula>
    {
        Task<bool> Create(PeliculaViewModel pelicula);

        Task<List<PeliculaViewModel>> GetAll();

        Task<PeliculaViewModel> GetById(int? id);

        Task<bool> Update(PeliculaViewModel pelicula);

        Task<bool> Delete(int? id);
        Task<bool> DeleteConfirmed(int? id);

   
    }
}
