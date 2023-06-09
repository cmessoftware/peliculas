using NetTopologySuite.Geometries;
using Peliculas.WebApi.Dto;

namespace Peliculas.Web.Dto
{
    public class CineDto
    {
        public string Nombre { get; set; }
        public string Cadena { get; set; }
        public List<PeliculaDto> Peliculas { get; set; }
        public List<SalaCineDto>? Salas { get; set; }
        public string LogoCine { get; set; }
        public Point Ubicacion { get; set; }
    }
}