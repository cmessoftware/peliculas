using NetTopologySuite.Geometries;

namespace Peliculas.Web.ViewModels
{
    public class CineViewModel
    {
        public string Nombre { get; set; }
        public string Cadena { get; set; }
        public List<PeliculaViewModel> Peliculas { get; set; }
        public List<SalaViewModel>? Salas { get; set; }
        public string LogoCine { get; set; }
        public Point Ubicacion { get; set; }
    }
}