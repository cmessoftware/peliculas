using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Mapeos
{
    internal class MapeoPelicula
    {

        internal static List<PeliculaDto> Map ( List<Pelicula> peliculas )
        {
            List<PeliculaDto> peliculasDto = new List<PeliculaDto> ();


            return peliculasDto;
        }

        internal static PeliculaDto Map ( Pelicula pelicula )
        {
            PeliculaDto peliculaDto = new PeliculaDto ();


            return peliculaDto;
        }
        internal static List<Pelicula> Map ( List<PeliculaDto> peliculasDto )
        {
            List<Pelicula> peliculas = new List<Pelicula> ();


            return peliculas;
        }


        internal static Pelicula Map ( PeliculaDto peliculaDto )
        {
            Pelicula pelicula = new Pelicula ();


            return pelicula;
        }
    }
}