using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Web.ViewModels;

namespace Peliculas.Web.Mapeos
{
    internal class GenerosMapper : IGenerosMapper
    {
        private static IMapper _mapper;

        public GenerosMapper()
        {
        }

        public GenerosMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<GeneroViewModel> Map(List<Genero> generos)
        {
            List<GeneroViewModel> generosResponse = null;

            foreach (var gen in generos)
            {
                generosResponse ??= new List<GeneroViewModel>();
                generosResponse.Add(_mapper.Map<Genero, GeneroViewModel>(gen));
            }

            return generosResponse;
        }
    }
}