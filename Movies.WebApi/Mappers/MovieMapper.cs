using AutoMapper;
using Movies.WebApi.Dto;
using Movies.WebApi.Entities;
using Movies.WebApi.Mappers;

namespace Movies.Web.Mapeos
{
    public class MovieMapper : IMovieMapper
    {
        private static IMapper _mapper;


        public MovieMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<MoviesDto> Map(List<Movie> peliculas)
        {
            List<MoviesDto> response = null;

            foreach (var p in peliculas)
            {
                response ??= new List<MoviesDto>();
                response.Add(_mapper.Map<Movie, MoviesDto>(p));
            }

            return response;
        }

    }
}