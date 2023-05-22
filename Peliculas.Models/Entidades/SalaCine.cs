using Peliculas.Data;
using Peliculas.Entidades;

namespace Peliculas.Entidades
{
    public class SalaCine
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public EnumTipoSalaDeCine Tipo { get; set; }

        public int CineId { get; set; }
        public Cine Cine { get; set; }

        public int UbicacionEnSalaId { get; set; }
        public List<UbicacionEnSala> UbicacionesEnSala { get; set; }

        public List<Entrada> Entradas { get; set; }

    }
}