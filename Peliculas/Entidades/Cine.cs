using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Peliculas.Entidades
{ 
    public class Cine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cadena { get; set; }
        //public Point Ubicacion { get; set; }
        
        public List<Pelicula> Peliculas { get; set; }
        public CineOferta CineOferta { get; set; }
        public NetTopologySuite.Geometries.Point Ubicacion { get; internal set; }
    }
}