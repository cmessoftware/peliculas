using Peliculas.Data;
using Peliculas.Web.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Peliculas.Entidades
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string FotoURL { get; set; }

        public EnumPais PaisOrigen { get; set; }

        public string Biografia { get; set; }

        public List<Pelicula> Peliculas { get; set; }

    }
}