using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Entidades
{
    public class Direccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        public string Pais { get; set; }

        public string Provincia { get; set; }

        public string Calle { get; set; }

        public int Numero { get; set; }

        public string Ciudad { get; set; }

        public string CP { get; set; }

    }
}