using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.DTOs
{
    public class GeneroDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}