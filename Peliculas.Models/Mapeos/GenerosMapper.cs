using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Web.ViewModels;

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

        public List<GeneroViewModelJson> MapJson(List<Genero> generos)
        {
            List<GeneroViewModelJson> generosResponse = null;

            foreach (var gen in generos)
            {
                generosResponse ??= new List<GeneroViewModelJson>();
                generosResponse.Add(_mapper.Map<Genero, GeneroViewModelJson>(gen));
            }

            return generosResponse;
        }
    }
}