using Peliculas.Entidades;

namespace Peliculas.Web.Entidades
{
    public class UbicacionEnSala
    {
        public int Id { get; set; }
        public bool Disponible { get; set; }
        public int Fila { get; set; }
        public int Columna { get; set; }
        public int SalaCineId { get; set; }
        public SalaCine SalaCine { get; set; }
    }
}
    