using Peliculas.Entidades;
using System.Drawing;

namespace Peliculas.Web.Entidades
{
    public class Entrada
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int? FuncionId { get; set; }
        public Funcion Funcion { get; set; }
       // public int? SalaCineId { get; set; }
       // public SalaCine SalaCine { get; set; }
        public int? ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public byte[] QRCodeImage { get; set; }
    }
}