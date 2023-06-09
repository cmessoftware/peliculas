using AutoMapper;
using Peliculas.WebApi.Dto.Genero;
using Peliculas.WebApi.Entidades;

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

        public List<GeneroDto> Map(List<Genero> generos)
        {
            List<GeneroDto> generosResponse = null;

            foreach (var gen in generos)
            {
                generosResponse ??= new List<GeneroDto>();
                generosResponse.Add(_mapper.Map<Genero, GeneroDto>(gen));
            }

            return generosResponse;
        }

    }
}