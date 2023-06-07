using AutoMapper;
using Peliculas.WebApi.Entidades;
using Peliculas.Web.Dto;
using Peliculas.WebApi.Mapeos;

namespace Peliculas.Web.Mapeos
{
    public class GeneroMapper : IGeneroMapper
    {
        private static IMapper _mapper;

        public GeneroMapper()
        {
        }

        public GeneroMapper(IMapper mapper)
        {

            _mapper = mapper;
        }

        public List<Genero> Map(List<GeneroDto> generos)
        {
            List<Genero> generosResponse = null;

            foreach (var gen in generos)
            {
                generosResponse ??= new List<Genero>();
                generosResponse.Add(_mapper.Map<GeneroDto, Genero>(gen));
            }

            return generosResponse;
        }

    }
}