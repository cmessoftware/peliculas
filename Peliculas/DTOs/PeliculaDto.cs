using System.Runtime.InteropServices;

namespace Peliculas.DTOs
{
    public class PeliculaDto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string PaisOrigen { get; set; }

        public string Resumen { get; set; }

        public string Director { get; set; }

        public string PosterLink { get; set; }

        public List<Actor> Actores { get; set; }

        public List<ComentarioDto> Comentarios { get; set; }

        public GeneroDto Genero { get; set; }

        public List<CineDto> Cines { get; set; }


    }
}
