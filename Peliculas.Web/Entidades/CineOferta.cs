using Microsoft.Build.Framework;

namespace Peliculas.Entidades
{
    public class CineOferta
    {
        
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PorcentajeDescuento { get; set; }

        //Por ahora solo una oferta por Cine, pero lo preparo para
        //un futuro con más de una por Cine.
        public int CineId { get; set; }
        public Cine Cine { get; set; }
    }
}