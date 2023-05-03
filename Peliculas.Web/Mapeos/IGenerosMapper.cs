using Peliculas.Entidades;
using Peliculas.Web.ViewModels;

namespace Peliculas.Web.Mapeos
{
    internal interface IGenerosMapper
    {
        public List<GeneroViewModel> Map(List<Genero> generos);
    }
}