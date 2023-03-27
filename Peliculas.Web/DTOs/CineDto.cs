using Peliculas.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using NetTopologySuite.Geometries;


namespace Peliculas.DTOs
{
    public class CineDto
    {
        public string Nombre { get; set; }
        public string Cadena { get; set; }
        public List<PeliculaDto> Peliculas { get; set; }
        public List<SalaDto>? Salas { get; set; }
        public DireccionDto Direccion { get; set; }
        public string LogoCine { get; set; }
        public Point Ubicacion { get; set; }
    }
}