using Peliculas.Entidades;
using Peliculas.Web.ViewModels;

namespace Peliculas.Web.Mapeos
{
    public interface IGenerosMapper
    {
        public List<GeneroViewModel> Map(List<Genero> generos);
    }
}