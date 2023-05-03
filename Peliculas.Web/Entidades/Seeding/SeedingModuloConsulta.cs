using Microsoft.EntityFrameworkCore;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using Peliculas.Data;
using Peliculas.Web.Entidades;
using System.Data;

namespace Peliculas.Entidades.Seeding
{
    internal class SeedingModuloConsulta
    {
        internal static void Seed(ModelBuilder modelBuilder)
        {
            var acción = new Genero { Id = 1, Nombre = "Acción" };
            var animación = new Genero { Id = 2, Nombre = "Animación" };
            var comedia = new Genero { Id = 3, Nombre = "Comedia" };
            var cienciaFicción = new Genero { Id = 4, Nombre = "Ciencia ficción" };
            var drama = new Genero { Id = 5, Nombre = "Drama" };
            var policial = new Genero { Id = 6, Nombre = "Policial" };
            var terror = new Genero { Id = 6, Nombre = "Terror" };
            var romantica = new Genero { Id = 6, Nombre = "Romantica" };
            var documental = new Genero { Id = 7, Nombre = "Documental" };
            var epica = new Genero { Id = 8, Nombre = "Epica" };
            var corto = new Genero { Id = 9, Nombre = "Corto" };
            var costumbrista = new Genero { Id = 10, Nombre = "Costumbrista" };
            var teatro = new Genero { Id = 11, Nombre = "Teatro" };


            modelBuilder.Entity<Genero>().HasData(acción, 
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

            var pelicula1 = new Pelicula()
            {
                Id = 1,
                Director = "Colin Trevorrow",
                Titulo = "Jurassic World - Dominion",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000001.png",
                Estreno = 2022,
                Resumen = "Tiempo después de los sucesos de Fallen Kingdom, los dinosaurios han vuelto a tomar el dominio en toda la tierra y los humanos tendrán que aprender a convivir con ellos mientras que un nuevo problema pondrá alta tensión a la situación. Owen Grady y Claire Dearing unirán fuerzas junto con la ayuda del famoso paleontólogo Alan Grant, la doctora Ellie Satler y el Doctor Ian Malcolm para resolverlo.",
                TrailerLink = "https://www.youtube.com/watch?v=9m9yRauMJIQ"
            };

            var pelicula2 = new Pelicula()
            {
                Id = 2,
                Director = "Max Power",
                Titulo = "Springfield World",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000003.png",
                Estreno = 2022,
                Resumen = "Gefärbt wiedersehn und dich ich seufzer gartens jedoch ich der komm ich brust dahinten junge es in herzen in kleinem",
                TrailerLink = "https://www.youtube.com/watch?v=9m9yRauMJIQ"
            };

            var pelicula3 = new Pelicula()
            {
                Id = 3,
                Director = "Max Power",
                Titulo = "Cocinando con Marge",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000002.png",
                Estreno = 2023,
                Resumen = "Kíntól jár élõk meleg hisz üszkösen ríjjátok minden boldog a s érti hull kénye s ha kíntól a nap a",
                TrailerLink = "https://www.youtube.com/watch?v=9m9yRauMJIQ"
            };

            modelBuilder.Entity<Pelicula>().HasData(pelicula1,
                                                    pelicula2,
                                                    pelicula3);

          
            var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);


            var cine1 = new Cine()
            {
                Id = 1,
                Cadena = "ShowCase",
                Nombre = "Alto Rosario",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-69.939248, 18.469649)),
                CineOfertas = new List<CineOferta>()
                {
                    new CineOferta()
                    {
                        CineId = 1,
                        FechaInicio = DateTime.Now,
                        FechaFin = DateTime.Now.AddDays(7)
                    }
                },
                SalasCine = new List<SalaCine>
                {
                    new SalaCine
                    {
                        Id = 40,
                        CineId = 1,
                        Nombre = "Sala Cine 2",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                     new SalaCine
                    {
                        Id = 41,
                        CineId = 1,
                        Nombre = "Sala Cine 3",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                      new SalaCine
                    {
                        Id = 42,
                        CineId = 1,
                        Nombre = "Sala Cine 4",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                       new SalaCine
                    {
                        Id = 43,
                        CineId = 1,
                        Nombre = "Sala Cine 5",
                        Tipo = EnumTipoSalaDeCine.Imax
                    }
                }
            };
                  
         
            var cine2 = new Cine()
            {
                Id = 2,
                Cadena = "ShowCase",
                Nombre = "Alto Palermo",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-69.9388777, 18.4839233)),
                CineOfertas = new List<CineOferta>()
                {
                new CineOferta()
                    {
                        CineId = 2,
                        FechaInicio = DateTime.Now,
                        FechaFin = DateTime.Now.AddDays(7)
                    }
                },
                SalasCine = new List<SalaCine>
                {
                    new SalaCine
                    {
                        Id = 50,
                        CineId = 2,
                        Nombre = "Sala Cine 2",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                     new SalaCine
                    {
                        Id = 51,
                        CineId = 2,
                        Nombre = "Sala Cine 3",
                        Tipo = EnumTipoSalaDeCine.DosDimensiones
                    },
                      new SalaCine
                    {
                        Id = 52, 
                        CineId = 2,
                        Nombre = "Sala Cine 4",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                       new SalaCine
                    {
                        Id = 53 ,
                        CineId = 2,
                        Nombre = "Sala Cine 5",
                        Tipo = EnumTipoSalaDeCine.Imax
                    }
                }

            };

            var cine3 = new Cine()
            {
                Id = 3,
                Cadena = "ShowCase",
                Nombre = "Alto Cordoba",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-69.911582, 18.482455)),
                CineOfertas = new List<CineOferta>()
                {
                    new CineOferta()
                    {
                        CineId = 3,
                        FechaInicio = DateTime.Now,
                        FechaFin = DateTime.Now.AddDays(7)
                    }
                },
                SalasCine = new List<SalaCine>
                {
                    new SalaCine
                    {
                        Id = 60,
                        CineId = 3,
                        Nombre = "Sala Cine 2",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                     new SalaCine
                    {
                        Id = 61,
                        CineId = 3,
                        Nombre = "Sala Cine 3",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                      new SalaCine
                    {
                        Id = 62,
                        CineId = 3,
                        Nombre = "Sala Cine 4",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                       new SalaCine
                    {
                        Id = 63,
                        CineId = 4,
                        Nombre = "Sala Cine 5",
                        Tipo = EnumTipoSalaDeCine.Imax
                    }
                }
            };

            var cine4 = new Cine()
            {
                Id = 4,
                Cadena = "ShowCase",
                Nombre = "Alto Avellaneda",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-69.856309, 18.506662)),
                CineOfertas = new List<CineOferta>()
                {
                    new CineOferta()
                    {
                        CineId = 4,
                        FechaInicio = DateTime.Now,
                        FechaFin = DateTime.Now.AddDays(7)
                    }
                },
                SalasCine = new List<SalaCine>
                {
                    new SalaCine
                    {
                        Id = 70,
                        CineId = 4,
                        Nombre = "Sala Cine 2",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                     new SalaCine
                    {
                        Id = 71,
                        CineId = 4,
                        Nombre = "Sala Cine 3",
                        Tipo = EnumTipoSalaDeCine.DosDimensiones
                    },
                      new SalaCine
                    {
                        Id = 72,
                        CineId = 4,
                        Nombre = "Sala Cine 4",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                       new SalaCine
                    {
                        Id = 74,
                        CineId = 4,
                        Nombre = "Sala Cine 5",
                        Tipo = EnumTipoSalaDeCine.Imax
                    }
                }
            };

            var cine5 = new Cine()
            {
                Id = 5,
                Cadena = "ShowCase",
                Nombre = "Mar Del Plata Mall",
                Ubicacion = geometryFactory.CreatePoint(new Coordinate(-59.939248, 18.469649)),
                CineOfertas = new List<CineOferta>()
                {
                new CineOferta()
                {
                    CineId = 5,
                    FechaInicio = DateTime.Now,
                    FechaFin = DateTime.Now.AddDays(7)
                }},
                SalasCine = new List<SalaCine>
                {
                    new SalaCine
                    {
                        Id = 80,
                        CineId = 5,
                        Nombre = "Sala Cine 2",
                        Tipo = EnumTipoSalaDeCine.TresDimensiones
                    },
                     new SalaCine
                    {
                        Id = 81,
                        CineId = 5,
                        Nombre = "Sala Cine 3",
                        Tipo = EnumTipoSalaDeCine.DosDimensiones
                    },
                      new SalaCine
                    {
                        Id = 81,
                        CineId = 5,
                        Nombre = "Sala Cine 4",
                        Tipo = EnumTipoSalaDeCine.DosDimensiones
                    },
                       new SalaCine
                    {
                        Id = 82,
                        CineId = 5,
                        Nombre = "Sala Cine 5",
                        Tipo = EnumTipoSalaDeCine.DosDimensiones
                    }
                }
            };


            modelBuilder.Entity<Cine>().HasData(cine1,cine2,cine3,cine4,cine5);


            var actor1 = new Actor()
            {
                Id = 1,
                Biografia = "Confiture la courus mers des récifs gonflé enfant des au que les couleurs les verts vacheries nuits heurté - seves",
                Nombre = "Matt Damon",
                Edad = 50,
                PaisOrigen = EnumPais.USA,
                FotoURL = ""
            };

            var actor2 = new Actor()
            {
                Id = 2,
                Biografia = "Mais rythmes vacheries j'ai quille je des les dispersant savez-vous a loin reculons de inouies pleins les que restais torpeurs",
                Nombre = "Olivia Mackenzie",
                Edad = 35,
                PaisOrigen = EnumPais.USA,
                FotoURL = ""
            };

            var actor3 = new Actor()
            {
                Id = 3,
                Biografia = "Peaux ni la vos ailé taché une j'ai mes les les et d'ineffables milieu vogueur de nuits embaumé nuits tout",
                Nombre = "Chris Pratt",
                Edad = 43,
                PaisOrigen = EnumPais.USA,
                FotoURL = ""
            };

            var actor4 = new Actor()
            {
                Id = 4,
                Biografia = "Morgauxtagmeze nebona ankaux kaj kaj pli neniu sur tre kiu sed al la de ilin longaspace iom kaj poste estus",
                Nombre = "Homero Simpson",
                Edad = 43,
                PaisOrigen = EnumPais.USA,
                FotoURL = ""
            };

            var actor5 = new Actor()
            {
                Id = 5,
                Biografia = "Que de soeurs aux couronne» mince son musculeux pauvre soeurs donne regard elle d'un humain se faite la son et",
                Nombre = "Mongomery Berns",
                Edad = 104,
                PaisOrigen = EnumPais.USA,
                FotoURL = ""
            };

            modelBuilder.Entity<Actor>().HasData(actor1,actor2,actor3,actor4,actor5);

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


            var comentario1 = new Comentario()
            {
                Id = 1,
                Contenido = "Me ha encantado la película de principio a fin. Mucho al aire libre y muchos dinosaurios locura de película, el guión muy bien hecho. La recomiendo 100%",
                Usuario = "Sergio Boscoscuro",
                MeGustaCantidad = 2
            };

            var comentario2 = new Comentario()
            {
                Id = 2,
                Contenido = "Me ha encantado, nunca había visto ninguna película de Jurassic y m ha dejado con sabor de querer verme todas las demás. nada aburrida y dinámica. la recomiendo.",
                Usuario = "Paula Rodríguez Correa",
                MeGustaCantidad = 0
            };

            var comentario3 = new Comentario()
            {
                Id = 3,
                Contenido = "Me fascinó!!!! Ayer en la sala hasta aplaudió el público cuando terminó la cinta, había jóvenes, adultos!!!! Los fans nos encantó, \"X\" los críticos, al final es una pelí para disfrutar entre la acción y la nostalgia, no es un documental de la vida en la tierra!!!!",
                Usuario = "Karina Hdez Mejia",
                MeGustaCantidad = 3
            };

            modelBuilder.Entity<Comentario>().HasData(comentario1,comentario2,comentario3);


            var critica1 = new Critica()
            {
                Id = -1,
                Autor = "Sandro Doreste Bermúdez",
                Contenido = "Aunque soy de agradecer los muchos guiños a Jurassic Park, la película no profundiza lo suficiente ni en los personajes ni en la trama ni, y esto podría haberla salvado entre su público objetivo, el nuevo tipo de dinosaurio introducido. Esperé casi toda la película, al menos mientras tuve esperanza, para ver cuál sería el giro que justificaría una producción así, como lograron hacer en Fallen Kingdom al sacar a los dinosaurios de la isla. Pero es que no lo hay. La historia promete sin llegar a dar nunca, pues la escena de acción de todo el elenco reunido es tensa, sí, pero con graves errores en los tiempos y, al igual que esta película para la saga Jurassic, omitible por falta de aportar a la trama general. Lo mejor: la primera y la última escena con las langostas y la persecución en Malta por la novedad del escenario."
            };

            var critica2 = new Critica()
            {
                Id = -2,
                Autor = "Ruth Estefany Gutierrez Santander",
                Contenido = "Soy super fan de la saga y esta ultima pelicula me hizo soltar algunas lagrimas es cierto q algunos detalles hubiera querido diferentes pero se guarda la esencia y para mi no pudo haber mejor final q este ame la pelicula y la animacion y el mensajed q transmite un buen final para la saga sus 5 estrellas merecidas."
            };

            modelBuilder.Entity<Critica>().HasData(critica1,critica2);
            
            var funcion1 = new Funcion()
            {
                Id = 1,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(2).AddHours(16).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula1,
                PeliculaId = pelicula1.Id,
            };

            var funcion2 = new Funcion()
            {
                Id = 1,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(2).AddHours(18).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula1,
                PeliculaId = pelicula1.Id,
            };

            var funcion3 = new Funcion()
            {
                Id = 1,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(2).AddHours(20).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula1,
                PeliculaId = pelicula1.Id,
            };

            var funcion4 = new Funcion()
            {
                Id = 4,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(4).AddHours(16).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula3,
                PeliculaId = pelicula3.Id,
            };

            var funcion5 = new Funcion()
            {
                Id = 5,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(4).AddHours(18).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula3,
                PeliculaId = pelicula3.Id,
            };

            var funcion6 = new Funcion()
            {
                Id = 6,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(4).AddHours(20).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula1,
                PeliculaId = pelicula3.Id,
            };

            var funcion7 = new Funcion()
            {
                Id = 7,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(4).AddHours(16).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula2,
                PeliculaId = pelicula2.Id,
            };

            var funcion8 = new Funcion()
            {
                Id = 8,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(4).AddHours(18).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula2,
                PeliculaId = pelicula2.Id,
            };

            var funcion9 = new Funcion()
            {
                Id = 9,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(6).AddHours(16).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula2,
                PeliculaId = pelicula2.Id,
            };

            var funcion10 = new Funcion()
            {
                Id = 1,
                Entradas = new List<Entrada>(),
                Fecha = DateTime.Now.AddDays(6).AddHours(18).AddMinutes(30),
                Nombre = "Funcion normal",
                Pelicula = pelicula2,
                PeliculaId = pelicula2.Id,
            };

            modelBuilder.Entity<Funcion>().HasData(funcion1, 
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