using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Peliculas.Data;

namespace Peliculas.Entidades
{
    public class SalaCine
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public EnumTipoSalaDeCine Tipo { get; set; }

        public decimal Precio { get; set; }

        public int CineId { get; set; }
        public Cine Cine { get; set; }

    }
}