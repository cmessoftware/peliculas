using Peliculas.Data;

namespace Peliculas.Web.ViewModels
{
    public class ActorViewModel
    {
      
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public EnumPais Pais { get; set; }
    }
}