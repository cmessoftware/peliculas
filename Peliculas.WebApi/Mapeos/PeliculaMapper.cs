using AutoMapper;
using Peliculas.WebApi.Dto;
using Peliculas.WebApi.Entidades;
using Peliculas.WebApi.Mapeos;

namespace Peliculas.Web.Mapeos
{
    public class PeliculaMapper : IPeliculaMapper
    {
        private static IMapper _mapper;


        public PeliculaMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<PeliculaDto> Map(List<Pelicula> peliculas)
        {
            List<PeliculaDto> response = null;

            foreach (var p in peliculas)
            {
                response ??= new List<PeliculaDto>();
                response.Add(_mapper.Map<Pelicula, PeliculaDto>(p));
            }

            return response;
        }

    }
}