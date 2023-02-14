using Peliculas.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Entidades
{
    public class Actor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int? Edad { get; set; }
        public string? Biografia { get; set; }

        public string? PaisOrigen { get; set; }
    }
}