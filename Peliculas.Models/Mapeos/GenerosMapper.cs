using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Web.Dto;

namespace Peliculas.Web.Mapeos
{
    public class GenerosMapper : IGenerosMapper
    {
        private static IMapper _mapper;

        public GenerosMapper()
        {
        }

        public GenerosMapper(IMapper mapper)
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