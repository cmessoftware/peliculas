using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Mapeos
{
    public class MapeosPeliculas
    {
        public static Pelicula Map(PeliculaDto peliculaDto)
        {

            //Mapeo lo que recibo de la vista a la entidad a esas en la base de datos.
            var pelicula = new Pelicula
            {
                Id = 8,
                Director = peliculaDto.Director,
                Titulo = peliculaDto.Nombre,
                PaisOrigen = peliculaDto.PaisOrigen,
                PosterLink = peliculaDto.PosterLink,
                FechaEstreno = peliculaDto.FechaEstreno,
                Resumen = peliculaDto.Resumen,
                PeliculasActores = new List<PeliculaActor>()
            };

            //foreach (var a in peliculaDto.Actores)
            //{
            //    var actor = new Actor()
            //    {
            //        Id = a.Id,
            //        Nombre = a.Nombre,
            //        Edad = a.Edad,
            //        PaisOrigen = a.Pais,
            //        ActorPeliculaRel = new PeliculaActor()
            //        {
            //            ActorId = a.ActorPeliculaRel.ActorId,
            //            Id = a.ActorPeliculaRel.Id,
            //            PeliculaID = a.ActorPeliculaRel.PeliculaID,
            //            EsPrincipal = a.ActorPeliculaRel.EsPrincipal
            //        }
            //    };

            //    pelicula.Actores.Add(actor);
            //}

            //pelicula.Genero = new Genero()
            //{
            //    Id = peliculaDto.Genero.Id,    
            //    Nombre = peliculaDto.Genero.Nombre
            //};

            //#region Cargo Cines con sus salas.
            //pelicula.Cines = new List<Cine>();

            //foreach (var c in peliculaDto.Cines)
            //{
            //    var cine = new Cine()
            //    {
            //        Cadena = c.Cadena,
            //        Nombre = c.Nombre,
            //        Direccion = new Direccion()
            //        {
            //            Calle = c.Direccion.Calle,
            //            Numero = c.Direccion.Numero,
            //            Ciudad = c.Direccion.Ciudad,
            //            Pais = c.Direccion.Pais,
            //            CP = c.Direccion.CP,
            //            Provincia = c.Direccion.Provincia
            //        }
            //    };

            //    cine.Salas = new List<SalaDeCine>();

            //    foreach (var s in c.Salas)
            //    {
            //        var sala = new SalaDeCine()
            //        {
            //            Nombre = s.Nombre,
            //            Tipo = new TipoSalaDeCine()
            //            {
            //                Nombre = s.Tipo.Nombre
            //            }
            //        };

            //        cine.Salas.Add(sala);
            //    }

            //    pelicula.Cines.Add(cine);
            //}
            //#endregion

            pelicula.Comentarios = new List<Comentario>();

            foreach (var com in peliculaDto.Comentarios)
            {
                var comentario = new Comentario()
                {
                    Id = com.Id,
                    Contenido = com.Contenido,
                    Usuario = com.Usuario,
                    MeGustaCantidad = com.MeGustaCantidad
                };

                pelicula.Comentarios.Add(comentario);

            }

            foreach (var cri in peliculaDto.Criticas)
            {
                var critica = new Critica()
                {
                    Id = cri.Id,
                    Autor = cri.Autor,
                    Contenido = cri.Contenido
                };
            }

           return pelicula;
        }
    }
}
