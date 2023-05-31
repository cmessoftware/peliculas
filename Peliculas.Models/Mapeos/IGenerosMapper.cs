using Peliculas.Entidades;
using Peliculas.Web.Dto;

namespace Peliculas.Web.Mapeos
{
    public interface IGenerosMapper
    {
        public List<GeneroDto> Map(List<Genero> generos);
    }
}