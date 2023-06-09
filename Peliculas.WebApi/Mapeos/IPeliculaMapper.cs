using Peliculas.WebApi.Dto;
using Peliculas.WebApi.Entidades;

namespace Peliculas.WebApi.Mapeos
{

    public interface IPeliculaMapper : IGenericMapper<PeliculaDto, Pelicula>
    {
        public List<PeliculaDto> Map(List<Pelicula> peliculas);
    }
}