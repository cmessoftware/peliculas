using Peliculas.Data;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Web.ViewModels
{
    public class PeliculaViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool EnCartelara { get; set; }

        [Display(Name = "Fecha de estreno")]
        public int Estreno { get; set; }
        public EnumPais PaisOrigen { get; set; }
        public string Resumen { get; set; }
        public string Director { get; set; }
        public string PosterLink { get; set; }
        public string TrailerLink { get; set; }
        public List<ComentarioViewModel> Comentarios { get; set; }
        public List<GeneroViewModel> Generos { get; set; }
        public List<CineViewModel> Cines { get; set; }

        public List<ActorViewModel> Actores { get; set; }

        public List<CriticaViewModel> Criticas { get; set; }


    }
}
