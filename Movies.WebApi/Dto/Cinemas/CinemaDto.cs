using NetTopologySuite.Geometries;
using Movies.WebApi.Dto;
using Movies.WebApi.Dto.SalasCines;

namespace Movies.WebApi.Dto.Cines
{
    public record CinemaDto
    {
        public string Nombre { get; set; }
        public string Cadena { get; set; }
        public List<MoviesDto> Peliculas { get; set; }
        public List<SalaCineDto>? Salas { get; set; }
        public string LogoCine { get; set; }
        public Point Ubicacion { get; set; }
    }
}