using Microsoft.AspNetCore.Mvc.Rendering;

namespace Peliculas.Web.ViewModels
{
    public class GeneroViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<SelectListItem> Generos { get; set; }
    }
}