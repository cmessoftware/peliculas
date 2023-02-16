using Peliculas.Data;
using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Servicios
{
    public class ServicioPeliculaMemoria : IServicioPelicula
    {
        public PeliculaDto GetPeliculaEstrenoById(int Id)
        {
            var peliculas = GetPeliculasEstreno();

            var pelicula = peliculas.Where(x => x.Id == Id).FirstOrDefault();

            return pelicula;
        }

        public void ActualizarComentarioLike(ComentarioDto? comentario, string idLike)
        {
            if (comentario != null)
            {
                if (idLike == "idLike")
                {
                    comentario.MeGustaCantidad++;
                }
                else
                {
                    if (comentario.MeGustaCantidad != comentario.MeGustaCantidad)
                    {
                        comentario.MeGustaCantidad--;
                    }
                }
            }
        }

        public List<PeliculaDto> GetPeliculasEstreno()
        {
            var peliculas = new List<PeliculaDto>();

            #region #1 Película

            var pelicula = new PeliculaDto ()
            {
                Id = 1,
                Director = "Colin Trevorrow",
                Nombre = "Jurassic World - Dominion",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000001.png",
                FechaEstreno = new DateTime ( 2022, 06, 02 ),
                Resumen = "Tiempo después de los sucesos de Fallen Kingdom, los dinosaurios han vuelto a tomar el dominio en toda la tierra y los humanos tendrán que aprender a convivir con ellos mientras que un nuevo problema pondrá alta tensión a la situación. Owen Grady y Claire Dearing unirán fuerzas junto con la ayuda del famoso paleontólogo Alan Grant, la doctora Ellie Satler y el Doctor Ian Malcolm para resolverlo.",
                Actores = new List<ActorDto> ()
                {
                    new ActorDto ()
                    {
                        Id = 111,
                        Nombre = "Chris Pratt",
                        Edad = 43,
                        Pais = EnumPais.USA,
                    },
                    new ActorDto ()
                    {
                        Id = 112,
                        Nombre = "Laura Dern",
                        Edad = 55,
                        Pais = EnumPais.USA,
                    }
                },
                Genero = new GeneroDto ()
                {
                    Nombre = "Ciencia Ficción"
                },
                Cines = new List<CineDto> ()
                {

                    new CineDto ()
                    {
                        Cadena = "ShowCase",
                        Nombre = "Alto Rosario",
                        LogoCine = "cine001.png",
                        Direccion = new DireccionDto ()
                        {
                            Calle = "Junin",
                            Numero = 501,
                            Ciudad = "Rosario",
                            Pais = "Argentina",
                            CP = "S2000",
                            Provincia = "Santa Fe"
                        },
                        Salas = new List<SalaDto> ()
                        {
                            new SalaDto ()
                            {
                                Nombre = "Sala 1",
                                Tipo = new TipoDto ()
                                {
                                    Nombre = "3D"
                                }
                            },
                            new SalaDto ()
                            {
                                Nombre = "Sala 2",
                                Tipo = new TipoDto ()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto ()
                            {
                                Nombre = "Sala 3",
                                Tipo = new TipoDto ()
                                {
                                    Nombre = "3D"
                                }
                            }
                        }
                    }
                },
                Comentarios = new List<ComentarioDto> ()
                {
                    new ComentarioDto ()
                    {
                        Id = 1,
                        Contenido = "Me ha encantado la película de principio a fin. Mucho al aire libre y muchos dinosaurios locura de película, el guión muy bien hecho. La recomiendo 100%",
                        Usuario = "Sergio Boscoscuro",
                        MeGustaCantidad = 2
                    },
                    new ComentarioDto ()
                    {
                        Id = 2,
                        Contenido = "Me ha encantado, nunca había visto ninguna película de Jurassic y m ha dejado con sabor de querer verme todas las demás. nada aburrida y dinámica. la recomiendo.",
                        Usuario = "Paula Rodríguez Correa",
                        MeGustaCantidad = 0
                    },
                    new ComentarioDto ()
                    {
                        Id = 3,
                        Contenido = "Me fascinó!!!! Ayer en la sala hasta aplaudió el público cuando terminó la cinta, había jóvenes, adultos!!!! Los fans nos encantó, \"X\" los críticos, al final es una pelí para disfrutar entre la acción y la nostalgia, no es un documental de la vida en la tierra!!!!",
                        Usuario = "Karina Hdez Mejia",
                        MeGustaCantidad = 3
                    }
                },
                Criticas = new List<CriticaDto> ()
                {
                    new CriticaDto ()
                    {
                        Autor = "Sandro Doreste Bermúdez",
                        Contenido = "Aunque sonnde agradecer los muchos guiños a Jurassic Park, la película no profundiza lo suficiente ni en los personajes ni en la trama ni, y esto podría haberla salvado entre su público objetivo, el nuevo tipo de dinosaurio introducido. Esperé casi toda la película, al menos mientras tuve esperanza, para ver cuál sería el giro que justificaría una producción así, como lograron hacer en Fallen Kingdom al sacar a los dinosaurios de la isla. Pero es que no lo hay. La historia promete sin llegar a dar nunca, pues la escena de acción de todo el elenco reunido es tensa, sí, pero con graves errores en los tiempos y, al igual que esta película para la saga Jurassic, omitible por falta de aportar a la trama general. Lo mejor: la primera y la última escena con las langostas y la persecución en Malta por la novedad del escenario."
                    },
                    new CriticaDto ()
                    {
                        Autor = "Ruth Estefany Gutierrez Santander",
                        Contenido = "Soy super fan de la saga y esta ultima pelicula me hizo soltar algunas lagrimas es cierto q algunos detalles hubiera querido diferentes pero se guarda la esencia y para mi no pudo haber mejor final q este ame la pelicula y la animacion y el mensajed q transmite un buen final para la saga sus 5 estrellas merecidas."
                    }
                },
                TrailerLink = "https://www.youtube.com/embed/fb5ELWi-ekk"

            };

            peliculas.Add(pelicula);

            #endregion

            #region #2 Película
            pelicula = new PeliculaDto()
            {
                Id = 2,
                Director = "Mike Newell",
                Nombre = "Harry Potter y el cáliz de fuego",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000002.png",
                FechaEstreno = new DateTime(2005, 11, 18),
                Resumen = "Hogwarts se prepara para el Torneo de los Tres Magos, en el que competirán tres escuelas de hechicería. Para sorpresa de todos, Harry Potter es elegido para participar en la competencia, en la que deberá luchar contra dragones, internarse en el agua y enfrentarse a sus mayores miedos.",
                Actores = new List<ActorDto>()
                {
                    new ActorDto()
                    {
                        Id = 113,
                        Nombre = "Emma Watson",
                        Edad = 15,
                        Pais = EnumPais.FRA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 113,
                        //   PeliculaID = 2,
                        //   EsPrincipal = true
                        //}
                    },
                    new ActorDto()
                    {
                        Id = 114,
                        Nombre = "James Phelps",
                        Edad = 19,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 114,
                        //   PeliculaID = 2,
                        //   EsPrincipal = false
                        //}
                    }
                },
                Genero = new GeneroDto()
                {
                    Nombre = "Fantasía"
                },
                Cines = new List<CineDto>()
                {

                    new CineDto()
                    {
                        Cadena = "ShowCase",
                        Nombre = "Alto Rosario",
                        LogoCine = "cine001.png",
                        Direccion = new DireccionDto()
                        {
                            Calle = "Junin",
                            Numero = 501,
                            Ciudad = "Rosario",
                            Pais = "Argentina",
                            CP = "S2000",
                            Provincia = "Santa Fe"
                        },
                        Salas = new List<SalaDto>()
                        {
                            new SalaDto()
                            {
                                Nombre = "Sala 1",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 2",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 3",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            }
                        }
                    }
                },
                Comentarios = new List<ComentarioDto>()
                {
                    new ComentarioDto()
                    {
                        Id = 1,
                        Contenido = "Para mí una de las mejores películas de la Saga. Hay un antes y un después de esta película. Muy entretenida desde el principio hasta el final. La recomiendo a todo el mundo.",
                        Usuario = "Alba Espejo",
                        MeGustaCantidad = 2
                    },
                     new ComentarioDto()
                    {
                        Id = 2,
                        Contenido = "Para mi es la mejor película de la saga Harry Potter la recomiendo un montón. Pero la verdad es que es donde empieza los momentos mas oscuros de Harry potter. Ya que revive el que no debe ser nombrado...",
                        Usuario = "Luis Domínguez Montes",
                        MeGustaCantidad = 0
                    },
                      new ComentarioDto()
                    {
                        Id = 3,
                        Contenido = "Tiene más aventuras y acción que las anteriores, Harry y sus amigos se enfrentas a más desafíos, sobre todo Harry quien deberá enfrentar a un gran desafío personal. Sin embargo se nota que el desenlace de la película fue muy rápida",
                        Usuario = "Lukas Flores",
                        MeGustaCantidad = 3
                    }
                },
                Criticas = new List<CriticaDto>()
                {
                    new CriticaDto()
                    {
                        Autor = "Itziar Marín Sáenz",
                        Contenido = "De los LIBROS de la SAGA de HARRY POTTER que me he leído, recomiendo un montón este, a mi me ha gustado mucho el libro, la película la veré dentro de poco, en fin, la MEJOR."
                    },
                    new CriticaDto()
                    {
                        Autor = "Carlos Ramírez",
                        Contenido = "La mejor película de la saga a juicio personal. Acción desde el 1er minuto, puedo verla muchas veces y no me aburriría de verla."
                    }
                },
                TrailerLink = "https://www.youtube.com/embed/wX5dWfUKGPg"
            };

            peliculas.Add(pelicula);

            #endregion

            #region #3 Película

            pelicula = new PeliculaDto()
            {
                Id = 3,
                Director = "Tim Story",
                Nombre = "Los 4 fantásticos",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000003.png",
                FechaEstreno = new DateTime(2005, 07, 08),
                Resumen = "Reed Richards. El piloto Ben Grimm y los miembros de la tripulación Susan Storm y su hermano Johnny Storm sobreviven a un aterrizaje de emergencia en un campo en la Tierra. Al salir del cohete, los cuatro descubren que han desarrollado superpoderes increíbles, y deciden usar estos poderes para ayudar a otros.",
                Actores = new List<ActorDto>()
                {
                    new ActorDto()
                    {
                        Id = 115,
                        Nombre = "Jessica Alba",
                        Edad = 24,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 115,
                        //   PeliculaID = 2,
                        //   EsPrincipal = false
                        //}
                    },
                    new ActorDto()
                    {
                        Id = 116,
                        Nombre = "Stan Lee",
                        Edad = 78,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 116,
                        //   PeliculaID = 2,
                        //   EsPrincipal = false
                        //}
                    }
                },
                Genero = new GeneroDto()
                {
                    Nombre = "Superhéroes"
                },
                Cines = new List<CineDto>()
                {
                    new CineDto()
                    {
                        Cadena = "Cinepolis Cine",
                        Nombre = "Cinepolis",
                        LogoCine = "cine002.png",
                        Direccion = new DireccionDto()
                        {
                            Calle = "Av. Eva Perón",
                            Numero = 5856,
                            Ciudad = "Rosario",
                            Pais = "Argentina",
                            CP = "S2000",
                            Provincia = "Santa Fe"
                        },
                        Salas = new List<SalaDto>()
                        {
                            new SalaDto()
                            {
                                Nombre = "Sala 1",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 2",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 3",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            }
                        }
                    }
                },
                Comentarios = new List<ComentarioDto>()
                {
                    new ComentarioDto()
                    {
                        Id = 1,
                        Contenido = "Me gustos intiresante porque tiene un buen guion los actores saben sus roles y lo hacen bien",
                        Usuario = "Jose Bustos vilches",
                        MeGustaCantidad = 4
                    },
                     new ComentarioDto()
                    {
                        Id = 2,
                        Contenido = "Horrible, pesima y mediocre mal ejecutada, teniendo actores verdaderamente excepsionales como Michael B Jordan y darle papeles asi de mediocres es lo peor\r\nNo le llega ni a los talones a sus antecesores ya que nisiquiera es  entretenida si pudiera poner -1 estrella lo haria",
                        Usuario = "LINKITO XD",
                        MeGustaCantidad = 0
                    },
                      new ComentarioDto()
                    {
                        Id = 3,
                        Contenido = "excelente película me encanto muy entretenida",
                        Usuario = "Odalis Isabel Vasquez Solorzano",
                        MeGustaCantidad = 3
                    }
                },
                Criticas = new List<CriticaDto>()
                {
                    new CriticaDto()
                    {
                        Autor = "Noe Castillo",
                        Contenido = "Es muy buena la película saben respetar la historia y cada personaje tiene un a característica que hace querer verla otra vez no voy a contar spoilers pero que bueno que hayan vuelto con lo de conocer el malo cuando acabe la película como solían hacerlo se los recomiendo a todos."
                    },
                    new CriticaDto()
                    {
                        Autor = "Diego Rojas",
                        Contenido = "A pesar de ser un intento mediocre, me resulta ser una película muy entretenida, a la cual le guardo cariño. \r\n\r\nHay una buena química entre los personajes, se siente real el sentimiento de fraternidad y amistad en una historia defectuosa, pero con agradables momentos de acción y de humor. Gran parte del guion es muy torpe, el CGI no se ve tan mal y la narrativa decae, desfigurándose ridícula cada vez que avanza."
                    }
                },
                TrailerLink = "https://www.youtube.com/embed/ulfOrOlZTf0"
            };

            peliculas.Add(pelicula);

            #endregion

            #region #4 Película

            pelicula = new PeliculaDto()
            {
                Id = 4,
                Director = "Eric Darnell",
                Nombre = "Madagascar",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000004.png",
                FechaEstreno = new DateTime(2005, 05, 27),
                Resumen = "Cuatro animales muy mimados del zoo de Nueva York naufragan en la isla de Madagascar y deben aprender a sobrevivir en un mundo salvaje.",
                Actores = new List<ActorDto>()
                {
                    new ActorDto()
                    {
                        Id = 117,
                        Nombre = "Ben Stiller (Voz de Alex el León)",
                        Edad = 40,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 117,
                        //   PeliculaID = 4,
                        //   EsPrincipal = true
                        //}
                    },
                    new ActorDto()
                    {
                        Id = 118,
                        Nombre = "Sacha Baron Cohen (Voz del Rey Julien)",
                        Edad = 34,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 118,
                        //   PeliculaID = 4,
                        //   EsPrincipal = true
                        //}
                    }
                },
                Genero = new GeneroDto()
                {
                    Nombre = "Animación"
                },
                Cines = new List<CineDto>()
                {
                    new CineDto()
                    {
                        Cadena = "Cinepolis Cine",
                        Nombre = "Cinepolis",
                        LogoCine = "cine003.png",
                        Direccion = new DireccionDto()
                        {
                            Calle = "Av. Eva Perón",
                            Numero = 5856,
                            Ciudad = "Rosario",
                            Pais = "Argentina",
                            CP = "S2000",
                            Provincia = "Santa Fe"
                        },
                        Salas = new List<SalaDto>()
                        {
                            new SalaDto()
                            {
                                Nombre = "Sala 1",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 2",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 3",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            }
                        }
                    }
                },
                Comentarios = new List<ComentarioDto>()
                {
                    new ComentarioDto()
                    {
                        Id = 1,
                        Contenido = "Está super genial esta peli. Las personajes, la historia, son muy buenos. Muy recomendable",
                        Usuario = "Eduardo Hernandéz",
                        MeGustaCantidad = 4
                    },
                     new ComentarioDto()
                    {
                        Id = 2,
                        Contenido = "Esta seria una pelicula parece el exito de sherk tanto como el fracaso que alvin y las ardillas pero bueno aunque madagascar no fue una mala pelicula si no es como sherk aunque  DreamWorks asi lo mejor para que su pelicula fuera tan exictosa como sherk pero si fue un exicto en critica y fue una de las sagas taquilleras que no ganaron el oscar pero si se gano el corazon de las personas que adoranron la pelicula",
                        Usuario = "Fabricio Carranza Meza",
                        MeGustaCantidad = 2
                    },
                      new ComentarioDto()
                    {
                        Id = 3,
                        Contenido = "Es una obra audiovisual perfecta, mejor que la mierda de Disney para pelear con Dreamworks, pero bueno, no bases tu opinión con idiotas de internet, si todavía no la viste, ve, te prometo que te va a encantar",
                        Usuario = "Lautaro Gudiño",
                        MeGustaCantidad = 3
                    }
                },
                Criticas = new List<CriticaDto>()
                {
                    new CriticaDto()
                    {
                        Autor = "Fanffy Alexander Méndez De La Paz",
                        Contenido = "Me gusta mucho Madagascar, es divertida, colorida, bien animada y los personajes son muy chistosos. Es un trabajo estupendo por parte de DreamWorks, en serio la recomiendo."
                    },
                    new CriticaDto()
                    {
                        Autor = "Nicole Klein",
                        Contenido = "Me parece una excelente cinematografía. Me recuerda a momentos en mi infancia en los que la vida era feliz y no tenía preocupaciones. Volverla a ver es un trago de alegría. Amo esta película. Y los amo a ustedes. Gracias."
                    }
                },
                TrailerLink = "https://www.youtube.com/embed/fq5zU9T_Hl4"
            };

            peliculas.Add(pelicula);

            #endregion

            #region #5 Película

            pelicula = new PeliculaDto()
            {
                Id = 5,
                Director = "Andrew Adamson, Vicky Jenson",
                Nombre = "Shrek",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000005.png",
                FechaEstreno = new DateTime(2001, 06, 27),
                Resumen = "Hace mucho tiempo, en una lejana ciénaga, vivía un ogro llamado Shrek. Un día, su preciada soledad se ve interrumpida por un montón de personajes de cuento de hadas que invaden su casa. Todos fueron desterrados de su reino por el malvado Lord Farquaad. Decidido a devolverles su reino y recuperar la soledad de su ciénaga, Shrek llega a un acuerdo con Lord Farquaad y va a rescatar a la princesa Fiona, la futura esposa del rey. Sin embargo, la princesa esconde un oscuro secreto.",
                Actores = new List<ActorDto>()
                {
                    new ActorDto()
                    {
                        Id = 119,
                        Nombre = "Mike Myers (Voz de Shrek)",
                        Edad = 38,
                        Pais = EnumPais.CAN,
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 119,
                        //   PeliculaID = 5,
                        //   EsPrincipal = true
                        //}
                    },
                    new ActorDto()
                    {
                        Id = 120,
                        Nombre = "Cameron Díaz (Voz de Fiona)",
                        Edad = 29,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 120,
                        //   PeliculaID = 5,
                        //   EsPrincipal = true
                        //}
                    }
                },
                Genero = new GeneroDto()
                {
                    Nombre = "Aventura"
                },
                Cines = new List<CineDto>()
                {
                    new CineDto()
                    {
                        Cadena = "Cine Ducal",
                        Nombre = "Cine Ducal",
                        LogoCine = "cine004.png",
                        Direccion = new DireccionDto()
                        {
                            Calle = "Lavalle",
                            Numero = 750,
                            Ciudad = "Rivadavia",
                            Pais = "Argentina",
                            CP = "M5567",
                            Provincia = "Mendoza"
                        },
                        Salas = new List<SalaDto>()
                        {
                            new SalaDto()
                            {
                                Nombre = "Sala 1",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 2",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 3",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            }
                        }
                    }
                },
                Comentarios = new List<ComentarioDto>()
                {
                    new ComentarioDto()
                    {
                        Id = 1,
                        Contenido = "La mejor de las películas de dreamworks y sin duda una de las mejores animadas de su época, con una historia entretenida que hace mofa a los clásicos de Disney. Fue una lástima que no pudiéramos poder escuchar a Chris Farley como el ogro carismático, pero al menos el personaje pudo rescatar su esencia y diseño. Cada vez que lo veré pensaré en él y en lo mucho que deseaba ser el personaje.",
                        Usuario = "Claudia Patricia Salas Acosta",
                        MeGustaCantidad = 4
                    },
                     new ComentarioDto()
                    {
                        Id = 2,
                        Contenido = "Es una película tan cool me transporta a la inocente infancia dónde cuentos como este eran tan reales para mí y tan llenos de magia en verdad es una de las mejores cosas que eh visto en mi vida. Amo todo esto su trama sus personajes todo.",
                        Usuario = "Milagros Cervantes",
                        MeGustaCantidad = 2
                    },
                      new ComentarioDto()
                    {
                        Id = 3,
                        Contenido = "Shrek, es una pelicula muy buena. Es apta para niños, adolescentes y adultos. Yo a mis 13 años la sigo viendo,  me parece un genial filme",
                        Usuario = "Guadalupe Falero",
                        MeGustaCantidad = 3
                    }
                },
                Criticas = new List<CriticaDto>()
                {
                    new CriticaDto()
                    {
                        Autor = "Yadier Francisco Pérez Litan",
                        Contenido = "Para mí es la segunda mejor película de Shrek. Es ideal para comenzar la historia del ogro, y a mi entender una obra maestra. Puntuación 8 de 10."
                    },
                    new CriticaDto()
                    {
                        Autor = "Marcela Tavella",
                        Contenido = "Está película toca serios problemas del mundo y eso hace que te profundizes con ella, los personajes tienen un excelente desarrollo y aparte, cada uno es usado en un buen contexto. Esta película es bastante triste ya que hay escenas dolorosas, no es apta para una persona sensible, aún así, se lleva mis dieces."
                    }
                },
                TrailerLink = "https://www.youtube.com/embed/CwXOrWvPBPk"
            };

            peliculas.Add(pelicula);

            #endregion

            #region #6 Película

            pelicula = new PeliculaDto()
            {
                Id = 6,
                Director = "Michael Apted",
                Nombre = "Las crónicas de Narnia: la travesía del Viajero del Alba",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000006.png",
                FechaEstreno = new DateTime(2010, 11, 30),
                Resumen = "Edmundo y Lucía junto con su primo Eustaquio emprenderán una nueva aventura con Caspian para explorar los desconocidos mares de Narnia. Recorriendo muchas islas que no aparecen en los mapas y enfrentando grandes peligros llegaran al fin del mundo para conocer el resto de su historia.",
                Actores = new List<ActorDto>()
                {
                    new ActorDto()
                    {
                        Id = 121,
                        Nombre = "Georgina Helen Henley",
                        Edad = 15,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 121,
                        //   PeliculaID = 6,
                        //   EsPrincipal = true
                        //}
                    },
                    new ActorDto()
                    {
                        Id = 122,
                        Nombre = "Liam Neeson (Voz de Aslan)",
                        Edad = 58,
                        Pais = EnumPais.GBR,
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 122,
                        //   PeliculaID = 6,
                        //   EsPrincipal = false
                        //}
                    }
                },
                Genero = new GeneroDto()
                {
                    Nombre = "Fantasía"
                },
                Cines = new List<CineDto>()
                {
                    new CineDto()
                    {
                        Cadena = "Cine Ducal",
                        Nombre = "Cine Ducal",
                        LogoCine = "cine001.png",
                        Direccion = new DireccionDto()
                        {
                            Calle = "Lavalle",
                            Numero = 750,
                            Ciudad = "Rivadavia",
                            Pais = "Argentina",
                            CP = "M5567",
                            Provincia = "Mendoza"
                        },
                        Salas = new List<SalaDto>()
                        {
                            new SalaDto()
                            {
                                Nombre = "Sala 1",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 2",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 3",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            }
                        }
                    }
                },
                Comentarios = new List<ComentarioDto>()
                {
                    new ComentarioDto()
                    {
                        Id = 1,
                        Contenido = "Me encanta al igual que la primera y la segunda llena de acción y su mensaje es muy bonito tan bien,le doy 10 de 10 la verdad la recomiendo,aun que a los que no les gustan las peliculas de acción no mucho",
                        Usuario = "Valentina¨Pintos",
                        MeGustaCantidad = 4
                    },
                     new ComentarioDto()
                    {
                        Id = 2,
                        Contenido = "una de las mejores peliculas me encanto sin duda alguna pasen los años que pasen seran de las mejores",
                        Usuario = "Norma Juliana Toala Quimis",
                        MeGustaCantidad = 2
                    },
                      new ComentarioDto()
                    {
                        Id = 3,
                        Contenido = "Aunque esta no me gusta tanto como las otras, está muy buena y el conflicto es muy sólido y original",
                        Usuario = "lilx.abiuwu",
                        MeGustaCantidad = 3
                    }
                },
                Criticas = new List<CriticaDto>()
                {
                    new CriticaDto()
                    {
                        Autor = "Patrick Torns",
                        Contenido = "Aunque en está tercera película Susan y Peter no estuvieron, fue muy genial, Edmon y Lucy estuvieron increíbles y Caspian también, me encantó todo, los escenarios, el vestuario, el elenco, los personajes, la trama, incluso el primo me cayó bien jaja, obvio esta tercera película no supera a la primera pero estuvo muy genial."
                    },
                    new CriticaDto()
                    {
                        Autor = "Anto Figueroa",
                        Contenido = "Narnia es una de las mejor sagas que e visto y la recomiendo a todos porque te puede llegar a hacer llorar por un rinoceronte y ademas los actores son muy bonitos."
                    }
                },
                TrailerLink = "https://www.youtube.com/embed/o81F2hvmYJQ"

            };

            peliculas.Add(pelicula);

            #endregion

            #region #7 Película

            pelicula = new PeliculaDto()
            {
                Id = 7,
                Director = "Shane Van Dyke",
                Nombre = "Titanic II",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000002.png",
                FechaEstreno = new DateTime(2010, 08, 24),
                Resumen = "Amy Maine ha sido contratada para trabajar en el Titanic 2, el trasatlántico más moderno y sofisticado de todos los tiempos, que inicia un viaje inaugural por el oceáno Atlántico. Cuando el padre de Amy, un geólogo, detecta el derrumbe de un glacial en Groenlandia, prevee que las consecuencias de este desastre natural serán fatales para el Titanic 2. El fragmento de hielo desprendido tiene el tamaño de Manhattan y se sitúa en el trayecto del buque.",
                Actores = new List<ActorDto>()
                {
                    new ActorDto()
                    {
                        Id = 123,
                        Nombre = "Bruce Davison",
                        Edad = 64,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 123,
                        //   PeliculaID = 7,
                        //   EsPrincipal = true
                        //}
                    },
                    new ActorDto()
                    {
                        Id = 124,
                        Nombre = "Brooke Burns",
                        Edad = 32,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 124,
                        //   PeliculaID = 7,
                        //   EsPrincipal = false
                        //}
                    }
                },
                Genero = new GeneroDto()
                {
                    Nombre = "Suspenso"
                },
                Cines = new List<CineDto>()
                {
                    new CineDto()
                    {
                        Cadena = "Hoyts",
                        Nombre = "Palace Garden",
                        LogoCine = "cine003.png",
                        Direccion = new DireccionDto()
                        {
                            Calle = "Mar del Plata",
                            Numero = 809,
                            Ciudad = "Palermo",
                            Pais = "Argentina",
                            CP = "C1179",
                            Provincia = "Buenos Aires"
                        },
                        Salas = new List<SalaDto>()
                        {
                            new SalaDto()
                            {
                                Nombre = "Sala 1",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 2",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 3",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            }
                        }
                    }
                },
                Comentarios = new List<ComentarioDto>()
                {
                    new ComentarioDto()
                    {
                        Id = 1,
                        Contenido = "De verdad que era como un show, se tiran al piso al subir las escaleras, gritan sin deseos, corren sin ganas de hacerlo. \r\nEl tipo sin dientes es lo mejor. La tarjeta de crédito para contener la sangre de una herida fue muy gracioso. Es una película muy graciosa, se reiran mucho. Una película de comedia muy mala.",
                        Usuario = "Yolvik Chacón Valero",
                        MeGustaCantidad = 4
                    },
                     new ComentarioDto()
                    {
                        Id = 2,
                        Contenido = "Le doy dos por simpática... Jajajajaja... Es para pasar el rato, muy mala... El guión un desastre, malo todo! Hay partes muy chistosas... Ella, que el barco se hunde pero nunca se saca los zapatos, un hombre que escapando quita del medio un chorro de agua con la mano como si fuese una rama de árbol, lo de la tarjeta de credito en la herida jajajajaja .. Los efectos, mejor ni hablar ! Diálogos pavos ! En fin, me rei jaja",
                        Usuario = "Alexia Dorado",
                        MeGustaCantidad = 2
                    },
                      new ComentarioDto()
                    {
                        Id = 3,
                        Contenido = "Vi la película hoy, y me cague de la risa por toda la cosa, si la ves en serio es horrible, terrorífica producción, mal actuación, mal guion, y una parodia a comparación de la primera.\r\nEn cambio, si la ves para un poco de risa, es perfecta, la mejor película de comedia de todo el mundo! Vale completamente 100% la pena!",
                        Usuario = "Slanted Gaming",
                        MeGustaCantidad = 3
                    }
                },
                Criticas = new List<CriticaDto>()
                {
                    new CriticaDto()
                    {
                        Autor = "José Luis Arias Cortéz",
                        Contenido = "Una joya cinematográfica que representa la humidad en un filme perfectamente correlacionado con un guion artistico y lleno de humanidad , esto sumado a sus efectos especiales , de alta calidad , hacen a esta pieza una maravilla histórica, convirtiéndose en la mejor filme de la filmografía del siglo 21."
                    },
                    new CriticaDto()
                    {
                        Autor = "Nicolás Escalada",
                        Contenido = "No entiendo como puede ser tan mala y con tanta falla en las ediciones. Son muy notables. A mi gusto, arruinaron una buena historia que fue Titanic haciendo la 2."
                    }
                }
            };

            peliculas.Add(pelicula);

            #endregion

            #region #8 Película

            pelicula = new PeliculaDto()
            {
                Id = 8,
                Director = "Todd Phillips",
                Nombre = "Guasón",
                PaisOrigen = EnumPais.USA,
                PosterLink = "000008.png",
                FechaEstreno = new DateTime(2019, 10, 03),
                Resumen = "Arthur Fleck adora hacer reír a la gente, pero su carrera como comediante es un fracaso. El repudio social, la marginación y una serie de trágicos acontecimientos lo conducen por el sendero de la locura y, finalmente, cae en el mundo del crimen.",
                Actores = new List<ActorDto>()
                {
                    new ActorDto()
                    {
                        Id = 125,
                        Nombre = "Joaquin Rafael Bottom",
                        Edad = 45,
                        Pais = EnumPais.PRI
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 125,
                        //   PeliculaID = 8,
                        //   EsPrincipal = true
                        //}
                    },
                    new ActorDto()
                    {
                        Id = 126,
                        Nombre = "Robert De Niro",
                        Edad = 76,
                        Pais = EnumPais.USA
                        //ActorPeliculaRel = new ActorPeliculaRel()
                        //{
                        //   ActorId = 126,
                        //   PeliculaID = 8,
                        //   EsPrincipal = true
                        //}
                    }
                },
                Genero = new GeneroDto()
                {
                    Nombre = "Drama"
                },
                Cines = new List<CineDto>()
                {
                    new CineDto()
                    {
                        Cadena = "Hoyts",
                        Nombre = "Palace Garden",
                        LogoCine = "cine004.png",
                        Direccion = new DireccionDto()
                        {
                            Calle = "Mar del Plata",
                            Numero = 809,
                            Ciudad = "Palermo",
                            Pais = "Argentina",
                            CP = "C1179",
                            Provincia = "Buenos Aires"
                        },
                        Salas = new List<SalaDto>()
                        {
                            new SalaDto()
                            {
                                Nombre = "Sala 1",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 2",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala 3",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            }
                        }
                    }
                },
                Comentarios = new List<ComentarioDto>()
                {
                    new ComentarioDto()
                    {
                        Id = 1,
                        Contenido = "Sublime actuacion de Joaquin, excelente pelicula, fotografia, música, ambientación. Es sencillamente de lo mejor que he visto en años.\r\n\r\nUn enfoque diferente de un comic de villanos, donde se lo puede ver más humano y refleja una problematica social vigente hoy dia. La falta de empatia de la gente para las personas que se ven diferentes o estan enfermas por un lado y la violencia que se vive. Simplemente espectacular y merecido todos los premios",
                        Usuario = "Marcela Jordan",
                        MeGustaCantidad = 5
                    },
                     new ComentarioDto()
                    {
                        Id = 2,
                        Contenido = "Es absolutamente espectacular y sin duda una película imprescindible. Nunca, en toda mi vida, había simpatizado tanto con un antagonista como con Joker. La labor de Joaquin Phoenix es realmente impecable, las tomas están muy bien realizadas y con verdadero gusto. A nivel narrativo es genuino y brillante (como una persona como Arthur Flec pasa a convertirse en Joker). En definitiva, es un placer cinematográfico que invita a ser visto cuantiosas veces. Me quito el sombrero.",
                        Usuario = "Midnight Wolf",
                        MeGustaCantidad = 1
                    },
                      new ComentarioDto()
                    {
                        Id = 3,
                        Contenido = "La mejor interpretación de Joker actualmente. Está bueno ver como se desencadenan sus trastornos mentales que lo llevan a hacer un maldito villano. Me encantó la actuación de Joaquín Phoenix, es realmente muy bueno. Su mirada, sus gestos, sus movimientos, su risa parecen de una persona con problemas mentales de verdad. Podría decir mucho mas pero es un excelente actor y no hay duda de eso. Saludos.",
                        Usuario = "Nadia Rob",
                        MeGustaCantidad = 2
                    }
                },
                Criticas = new List<CriticaDto>()
                {
                    new CriticaDto()
                    {
                        Autor = "Magdalena Giovannone",
                        Contenido = "Me encantó. Una excelente película. La historia es muy conmovedora, inmersa de tristeza e impotencia. La actuación del fántastico Joaquín Phoenix es sublime. Por otra parte, la banda sonora es espectacular, la ambientación es sensacional y las escenas son siempre secuencias del protagonista, sin ningún tipo de interrupción, lo cuál me resulta destacable."
                    },
                    new CriticaDto()
                    {
                        Autor = "Adiel Leonardo Apaza Carpio",
                        Contenido = "Joaquin Phoenix convierte las carcajadas en tos nerviosa, y la sonrisa en el primer síntoma de una enfermedad que se extiende mucho más allá de su cuerpo.  Lo mejor de ‘Joker’ es que detrás esconde a un cineasta utilizando el universo prestado... y que nunca es la adaptación la que le está utilizando a él. Una película amoral, que nos recuerda que la anarquía tiene un componente humorístico irresistible, incluso liberador."
                    }
                },
                TrailerLink = "https://www.youtube.com/embed/TobNCFMK_bs"
            };

            peliculas.Add(pelicula);

            #endregion 

            return peliculas;
        }


        public PeliculaDto GetPeliculasEstrenoById(int Id)
        {
            var peliculas = GetPeliculasEstreno();

            var pelicula = peliculas.Where(x => x.Id == Id).FirstOrDefault();

            return pelicula;
        }

        public void CrearPelicula(PeliculaDto peliculaDto)
        {
            //Mapeo lo que recibo de la vista a la entidad a esas en la base de datos.
            var pelicula = new Pelicula()
            {
                Id = 8,
                Director = peliculaDto.Director,
                Titulo = peliculaDto.Nombre,
                PaisOrigen = peliculaDto.PaisOrigen,
                PosterLink = peliculaDto.PosterLink,
                FechaEstreno = peliculaDto.FechaEstreno,
                Resumen = peliculaDto.Resumen
            };

            pelicula.PeliculaActores = new List<PeliculaActor>();

            foreach (var a in peliculaDto.Actores)
            {
                var actor = new Actor()
                {
                    Id = a.Id,
                    Nombre = a.Nombre,
                    Edad = a.Edad,
                    PaisOrigen = a.Pais,
                    //PeliculaActores = new List<PeliculaActores>
                    //{
                    //    new 
                    //    ActorId = a.ActorPeliculaRel.ActorId,
                    //    Id = a.ActorPeliculaRel.Id,
                    //    PeliculaId = a.ActorPeliculaRel.PeliculaId,
                    //    EsPrincipal = a.ActorPeliculaRel.EsPrincipal
                    //}
                };

                //pelicula.PeliculaActores.Add(actor);
             }

            //pelicula.Genero = new Genero()
            //{
            //    Nombre = peliculaDto.Genero.Nombre
            //};

            #region Cargo Cines con sus salas.
           // pelicula.Cines = new List<Cine>();

            foreach (var c in peliculaDto.Cines)
            {
                var cine = new Cine()
                {
                    Cadena = c.Cadena,
                    Nombre = c.Nombre,
                    //Direccion = new Direccion()
                    //{
                    //    Calle = c.Direccion.Calle,
                    //    Numero = c.Direccion.Numero,
                    //    Ciudad = c.Direccion.Ciudad,
                    //    Pais = c.Direccion.Pais,
                    //    CP = c.Direccion.CP,
                    //    Provincia = c.Direccion.Provincia
                    //}
                };

                //cine.Salas = new List<SalaCine>();

                foreach (var s in c.Salas)
                {
                    //var sala = new SalaCine()
                    //{
                    //    Nombre = s.Nombre,
                    //    Tipo = new Tipo()
                    //    {
                    //        Nombre = s.Tipo.Nombre
                    //    }
                    //};

                   // cine.Salas.Add(sala);
                }

               // pelicula.Cines.Add(cine);
            }
            #endregion

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
                    Autor = cri.Autor,
                    Contenido = cri.Contenido

                };
            }

            //Persistir en la base de datos.

        }


        public void InsertarPelicula(Pelicula pelicula)
        {
            
        }
    }
}
