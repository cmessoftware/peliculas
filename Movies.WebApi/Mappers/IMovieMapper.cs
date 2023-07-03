using Movies.WebApi.Dto;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Mappers
{

    public interface IMovieMapper : IGenericMapper<MoviesDto, Movie>
    {
        public List<MoviesDto> Map(List<Movie> peliculas);
    }
}