using AutoMapper;
using Movies.WebApi.Dto.Genero;
using Movies.WebApi.Entities;

namespace Movies.Web.Mapeos
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

        public List<GeneroDto> Map(List<Gender> generos)
        {
            List<GeneroDto> generosResponse = null;

            foreach (var gen in generos)
            {
                generosResponse ??= new List<GeneroDto>();
                generosResponse.Add(_mapper.Map<Gender, GeneroDto>(gen));
            }

            return generosResponse;
        }

    }
}