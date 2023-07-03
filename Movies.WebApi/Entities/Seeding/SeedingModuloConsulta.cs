using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using Movies.Data;
using Movies.Web.Enums;
using Movies.WebApi.Entities;
using System.Security.Cryptography.Xml;

namespace Movies.WebApi.Entities.Seeding
{
    internal class SeedingModuloConsulta
    {
        internal static void Seed(ModelBuilder modelBuilder)
        {
            var acción = new Gender { Id = 1, Name = "Acción" };
            var animación = new Gender { Id = 2, Name = "Animación" };
            var comedia = new Gender { Id = 3, Name = "Comedia" };
            var cienciaFicción = new Gender { Id = 4, Name = "Ciencia ficción" };
            var drama = new Gender { Id = 5, Name = "Drama" };
            var policial = new Gender { Id = 6, Name = "Policial" };
            var terror = new Gender { Id = 6, Name = "Terror" };
            var romantica = new Gender { Id = 6, Name = "Romantica" };
            var documental = new Gender { Id = 7, Name = "Documental" };
            var epica = new Gender { Id = 8, Name = "Epica" };
            var corto = new Gender { Id = 9, Name = "Corto" };
            var costumbrista = new Gender { Id = 10, Name = "Costumbrista" };
            var teatro = new Gender { Id = 11, Name = "Teatro" };


            modelBuilder.Entity<Gender>().HasData(acción,
                                                  animación,
                                                  comedia,
                                                  cienciaFicción,
                                                  drama,
                                                  policial,
                                                  terror,
                                                  romantica,
                                                  documental,
                                                  epica,
                                                  corto,
                                                  costumbrista,
                                                  teatro);

            var pelicula1 = new Movie()
            {
                Id = 1,
                Director = "Colin Trevorrow",
                Title = "Jurassic World - Dominion",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000001.png",
                ReleaseDate = 2022,
                Summary = "Tiempo después de los sucesos de Fallen Kingdom, los dinosaurios han vuelto a tomar el dominio en toda la tierra y los humanos tendrán que aprender a convivir con ellos mientras que un nuevo problema pondrá alta tensión a la situación. Owen Grady y Claire Dearing unirán fuerzas junto con la ayuda del famoso paleontólogo Alan Grant, la doctora Ellie Satler y el Doctor Ian Malcolm para resolverlo.",
                TrailerLink = "https://www.youtube.com/watch?v=9m9yRauMJIQ"
            };

            var pelicula2 = new Movie()
            {
                Id = 2,
                Director = "Max Power",
                Title = "Springfield World",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000003.png",
                ReleaseDate = 2022,
                Summary = "Gefärbt wiedersehn und dich ich seufzer gartens jedoch ich der komm ich brust dahinten junge es in herzen in kleinem",
                TrailerLink = "https://www.youtube.com/watch?v=9m9yRauMJIQ"
            };

            var pelicula3 = new Movie()
            {
                Id = 3,
                Director = "Max Power",
                Title = "Cocinando con Marge",
                OriginCountry = (int)EnumCountry.USA,
                PosterLink = "000002.png",
                ReleaseDate = 2023,
                Summary = "Kíntól jár élõk meleg hisz üszkösen ríjjátok minden boldog a s érti hull kénye s ha kíntól a nap a",
                TrailerLink = "https://www.youtube.com/watch?v=9m9yRauMJIQ"
            };

            modelBuilder.Entity<Movie>().HasData(pelicula1,
                                                    pelicula2,
                                                    pelicula3);


            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);


            var cine1 = new Cinema()
            {
                Id = 1,
                Chain = "ShowCase",
                Name = "Alto Rosario",
                Location = geometryFactory.CreatePoint(new Coordinate(-69.939248, 18.469649)),
                CinemaOffer = new List<CinemaOffer>()
                {
                    new CinemaOffer()
                    {
                        CinemaId = 1,
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(7)
                    }
                },
                CinemaRoom = new List<RoomCinema>
                {
                    new RoomCinema
                    {
                        Id = 40,
                        CineId = 1,
                        Name = "Sala Cine 2",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                     new RoomCinema
                    {
                        Id = 41,
                        CineId = 1,
                        Name = "Sala Cine 3",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                      new RoomCinema
                    {
                        Id = 42,
                        CineId = 1,
                        Name = "Sala Cine 4",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                       new RoomCinema
                    {
                        Id = 43,
                        CineId = 1,
                        Name = "Sala Cine 5",
                        Type = (int)EnumRoomCinemaTypes.IMAX
                    }
                }
            };


            var cine2 = new Cinema()
            {
                Id = 2,
                Chain = "ShowCase",
                Name = "Alto Palermo",
                Location = geometryFactory.CreatePoint(new Coordinate(-69.9388777, 18.4839233)),
                CinemaOffer = new List<CinemaOffer>()
                {
                new CinemaOffer()
                    {
                        CinemaId = 2,
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(7)
                    }
                },
                CinemaRoom = new List<RoomCinema>
                {
                    new RoomCinema
                    {
                        Id = 50,
                        CineId = 2,
                        Name = "Sala Cine 2",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                     new RoomCinema
                    {
                        Id = 51,
                        CineId = 2,
                        Name = "Sala Cine 3",
                        Type = (int)EnumRoomCinemaTypes.TWODIMENSIONS
                    },
                      new RoomCinema
                    {
                        Id = 52,
                        CineId = 2,
                        Name = "Sala Cine 4",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                       new RoomCinema
                    {
                        Id = 53 ,
                        CineId = 2,
                        Name = "Sala Cine 5",
                        Type = (int)EnumRoomCinemaTypes.IMAX
                    }
                }

            };

            var cine3 = new Cinema()
            {
                Id = 3,
                Chain = "ShowCase",
                Name = "Alto Cordoba",
                Location = geometryFactory.CreatePoint(new Coordinate(-69.911582, 18.482455)),
                CinemaOffer = new List<CinemaOffer>()
                {
                    new CinemaOffer()
                    {
                        CinemaId = 3,
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(7)
                    }
                },
                CinemaRoom = new List<RoomCinema>
                {
                    new RoomCinema
                    {
                        Id = 60,
                        CineId = 3,
                        Name = "Sala Cine 2",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                     new RoomCinema
                    {
                        Id = 61,
                        CineId = 3,
                        Name = "Sala Cine 3",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                      new RoomCinema
                    {
                        Id = 62,
                        CineId = 3,
                        Name = "Sala Cine 4",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                       new RoomCinema
                    {
                        Id = 63,
                        CineId = 4,
                        Name = "Sala Cine 5",
                        Type = (int)EnumRoomCinemaTypes.IMAX
                    }
                }
            };

            var cine4 = new Cinema()
            {
                Id = 4,
                Chain = "ShowCase",
                Name = "Alto Avellaneda",
                Location = geometryFactory.CreatePoint(new Coordinate(-69.856309, 18.506662)),
                CinemaOffer = new List<CinemaOffer>()
                {
                    new CinemaOffer()
                    {
                        CinemaId = 4,
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(7)
                    }
                },
                CinemaRoom = new List<RoomCinema>
                {
                    new RoomCinema
                    {
                        Id = 70,
                        CineId = 4,
                        Name = "Sala Cine 2",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                     new RoomCinema
                    {
                        Id = 71,
                        CineId = 4,
                        Name = "Sala Cine 3",
                        Type = (int)EnumRoomCinemaTypes.TWODIMENSIONS
                    },
                      new RoomCinema
                    {
                        Id = 72,
                        CineId = 4,
                        Name = "Sala Cine 4",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                       new RoomCinema
                    {
                        Id = 74,
                        CineId = 4,
                        Name = "Sala Cine 5",
                        Type = (int)EnumRoomCinemaTypes.IMAX
                    }
                }
            };

            var cine5 = new Cinema()
            {
                Id = 5,
                Chain = "ShowCase",
                Name = "Mar Del Plata Mall",
                Location = geometryFactory.CreatePoint(new Coordinate(-59.939248, 18.469649)),
                CinemaOffer = new List<CinemaOffer>()
                {
                new CinemaOffer()
                {
                    CinemaId = 5,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(7)
                }},
                CinemaRoom = new List<RoomCinema>
                {
                    new RoomCinema
                    {
                        Id = 80,
                        CineId = 5,
                        Name = "Sala Cine 2",
                        Type = (int)EnumRoomCinemaTypes.THREEDIMENSIONS
                    },
                     new RoomCinema
                    {
                        Id = 81,
                        CineId = 5,
                        Name = "Sala Cine 3",
                        Type = (int)EnumRoomCinemaTypes.TWODIMENSIONS
                    },
                      new RoomCinema
                    {
                        Id = 81,
                        CineId = 5,
                        Name = "Sala Cine 4",
                        Type = (int)EnumRoomCinemaTypes.TWODIMENSIONS
                    },
                       new RoomCinema
                    {
                        Id = 82,
                        CineId = 5,
                        Name = "Sala Cine 5",
                        Type = (int)EnumRoomCinemaTypes.TWODIMENSIONS
                    }
                }
            };


            modelBuilder.Entity<Cinema>().HasData(cine1, cine2, cine3, cine4, cine5);


            var actor1 = new Actor()
            {
                Id = 1,
                Biography = "Confiture la courus mers des récifs gonflé enfant des au que les couleurs les verts vacheries nuits heurté - seves",
                Name = "Matt Damon",
                Age = 50,
                OriginCountry = (int)EnumCountry.USA,
                UrlPhoto = ""
            };

            var actor2 = new Actor()
            {
                Id = 2,
                Biography = "Mais rythmes vacheries j'ai quille je des les dispersant savez-vous a loin reculons de inouies pleins les que restais torpeurs",
                Name = "Olivia Mackenzie",
                Age = 35,
                OriginCountry = (int)EnumCountry.USA,
                UrlPhoto = ""
            };

            var actor3 = new Actor()
            {
                Id = 3,
                Biography = "Peaux ni la vos ailé taché une j'ai mes les les et d'ineffables milieu vogueur de nuits embaumé nuits tout",
                Name = "Chris Pratt",
                Age = 43,
                OriginCountry = (int)EnumCountry.USA,
                UrlPhoto = ""
            };

            var actor4 = new Actor()
            {
                Id = 4,
                Biography = "Morgauxtagmeze nebona ankaux kaj kaj pli neniu sur tre kiu sed al la de ilin longaspace iom kaj poste estus",
                Name = "Homero Simpson",
                Age = 43,
                OriginCountry = (int)EnumCountry.USA,
                UrlPhoto = ""
            };

            var actor5 = new Actor()
            {
                Id = 5,
                Biography = "Que de soeurs aux couronne» mince son musculeux pauvre soeurs donne regard elle d'un humain se faite la son et",
                Name = "Mongomery Berns",
                Age = 104,
                OriginCountry = (int)EnumCountry.USA,
                UrlPhoto = ""
            };

            modelBuilder.Entity<Actor>().HasData(actor1, actor2, actor3, actor4, actor5);

            //var peliculasActores1 = new PeliculaActor()
            //{
            //    Id = 1,
            //    EsPrincipal = true,
            //    Orden = 1,
            //    PeliculaId = 1,
            //    Personaje = "Mosca",
            //    ActorId = 1

            //};
            //var peliculasActores2 = new PeliculaActor()
            //{
            //    Id = 2, 
            //    EsPrincipal = false,
            //    Orden = 2,
            //    PeliculaId = 1,
            //    Personaje = "Merlina",
            //    ActorId = 2
            //};
            //var peliculasActores3 = new PeliculaActor()
            //{
            //    Id = 3,
            //    EsPrincipal = false,
            //    Orden = 4,
            //    PeliculaId = 1,
            //    Personaje = "Merlina",
            //    ActorId = 3
            //};
            //modelBuilder.Entity<PeliculaActor>().HasData(peliculasActores1, peliculasActores2, peliculasActores3);


            var comentario1 = new Comments()
            {
                Id = 1,
                Content = "Me ha encantado la película de principio a fin. Mucho al aire libre y muchos dinosaurios locura de película, el guión muy bien hecho. La recomiendo 100%",
                //Client = "Sergio Boscoscuro",
                Likes = 2
            };

            var comentario2 = new Comments()
            {
                Id = 2,
                Content = "Me ha encantado, nunca había visto ninguna película de Jurassic y m ha dejado con sabor de querer verme todas las demás. nada aburrida y dinámica. la recomiendo.",
                ////Client = new Client{  "Paula Rodríguez Correa",
                Likes = 0
            };

            var comentario3 = new Comments()
            {
                Id = 3,
                Content = "Me fascinó!!!! Ayer en la sala hasta aplaudió el público cuando terminó la cinta, había jóvenes, adultos!!!! Los fans nos encantó, \"X\" los críticos, al final es una pelí para disfrutar entre la acción y la nostalgia, no es un documental de la vida en la tierra!!!!",
                //Client = "Karina Hdez Mejia",
                Likes = 3
            };

            modelBuilder.Entity<Comments>().HasData(comentario1, comentario2, comentario3);


            var critica1 = new Critics()
            {
                Id = -1,
                Autor = "Sandro Doreste Bermúdez",
                Content = "Aunque soy de agradecer los muchos guiños a Jurassic Park, la película no profundiza lo suficiente ni en los personajes ni en la trama ni, y esto podría haberla salvado entre su público objetivo, el nuevo tipo de dinosaurio introducido. Esperé casi toda la película, al menos mientras tuve esperanza, para ver cuál sería el giro que justificaría una producción así, como lograron hacer en Fallen Kingdom al sacar a los dinosaurios de la isla. Pero es que no lo hay. La historia promete sin llegar a dar nunca, pues la escena de acción de todo el elenco reunido es tensa, sí, pero con graves errores en los tiempos y, al igual que esta película para la saga Jurassic, omitible por falta de aportar a la trama general. Lo mejor: la primera y la última escena con las langostas y la persecución en Malta por la novedad del escenario."
            };

            var critica2 = new Critics()
            {
                Id = -2,
                Autor = "Ruth Estefany Gutierrez Santander",
                Content = "Soy super fan de la saga y esta ultima pelicula me hizo soltar algunas lagrimas es cierto q algunos detalles hubiera querido diferentes pero se guarda la esencia y para mi no pudo haber mejor final q este ame la pelicula y la animacion y el mensajed q transmite un buen final para la saga sus 5 estrellas merecidas."
            };

            modelBuilder.Entity<Critics>().HasData(critica1, critica2);

            var funcion1 = new Function()
            {
                Id = 1,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(2).AddHours(16).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula1,
                MovieId = pelicula1.Id,
            };

            var funcion2 = new Function()
            {
                Id = 1,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(2).AddHours(18).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula1,
                MovieId = pelicula1.Id,
            };

            var funcion3 = new Function()
            {
                Id = 1,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(2).AddHours(20).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula1,
                MovieId = pelicula1.Id,
            };

            var funcion4 = new Function()
            {
                Id = 4,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(4).AddHours(16).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula3,
                MovieId = pelicula3.Id,
            };

            var funcion5 = new Function()
            {
                Id = 5,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(4).AddHours(18).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula3,
                MovieId = pelicula3.Id,
            };

            var funcion6 = new Function()
            {
                Id = 6,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(4).AddHours(20).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula1,
                MovieId = pelicula3.Id,
            };

            var funcion7 = new Function()
            {
                Id = 7,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(4).AddHours(16).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula2,
                MovieId = pelicula2.Id,
            };

            var funcion8 = new Function()
            {
                Id = 8,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(4).AddHours(18).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula2,
                MovieId = pelicula2.Id,
            };

            var funcion9 = new Function()
            {
                Id = 9,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(6).AddHours(16).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula2,
                MovieId = pelicula2.Id,
            };

            var funcion10 = new Function()
            {
                Id = 1,
                Ticket = new List<Ticket>(),
                Date = DateTime.Now.AddDays(6).AddHours(18).AddMinutes(30),
                Name = "Funcion normal",
                Movie = pelicula2,
                MovieId = pelicula2.Id,
            };

            modelBuilder.Entity<Function>().HasData(funcion1,
                                                   funcion2,
                                                   funcion3,
                                                   funcion4,
                                                   funcion5,
                                                   funcion6,
                                                   funcion7,
                                                   funcion8,
                                                   funcion9,
                                                   funcion10);

        }
    }
}