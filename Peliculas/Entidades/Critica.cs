using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Entidades
{
    public class Critica 
    {
        public int Id { get; set; }

        public string Contenido { get; set; }
        public string Autor { get; set; }

    }
}
