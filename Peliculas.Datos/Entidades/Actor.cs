using Peliculas.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Entidades
{
    public class Actor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string FotoURL { get; set; }

        public EnumPais PaisOrigen { get; set; }

        public string Biografia { get; set; }

        public List<PeliculaActor> PeliculaActores { get; set; }
    }
}