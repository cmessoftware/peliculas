using Microsoft.AspNetCore.Mvc;
using Peliculas.DTOs;
using Peliculas.Models;
using System.Diagnostics;

namespace Peliculas.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly ILogger<PeliculasController> _logger;

        public PeliculasController(ILogger<PeliculasController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var peliculasEstreno = GetPeliculasEstreno();

            return View(peliculasEstreno);
        }

        [HttpGet]
        [Route("{resumen}/{id}")]
        public IActionResult Resumen(int id)
        {
            var resumen = GetPeliculasEstrenoById(id);

            return View(resumen);

        }

        [HttpGet]
        [Route("{resumen}/{id}/{comentarioId}")]
        public IActionResult Likes(int id, int comentarioId)
        {
            var resumen = GetPeliculasEstrenoById(id);

            var comentario = resumen.Comentarios.Where(c => c.Id == comentarioId).FirstOrDefault();

            if (comentario != null)
                comentario.MeGustaCantidad++;

            //ActualizarComentarioLike(comentario);


            return View("Resumen",resumen);

        }

        private void ActualizarComentarioLike(ComentarioDto? comentario)
        {
            throw new NotImplementedException();
        }

        private PeliculaDto GetPeliculasEstrenoById(int id)
        {
            var peliculas = GetPeliculasEstreno();

            var pelicula = peliculas.Where(x => x.Id == id).FirstOrDefault();

            return pelicula;
        }

        private List<PeliculaDto> GetPeliculasEstreno()
        {
            var peliculas = new List<PeliculaDto>();

            var pelicula = new PeliculaDto();

            pelicula.Actores = new List<ActorDto>();
            var actor = new ActorDto();
            actor.Nombre = "Jack Nicolson";
            pelicula.Actores.Add(actor);
            actor = new ActorDto();
            actor.Nombre = "Pepe";
            pelicula.Actores.Add(actor);
            pelicula.Cines = new List<CineDto>();
            var cine = new CineDto();
            cine.Cadena = "Hoyts";
            cine.Nombre = "Caballito Center";
            cine.Sala = new List<SalaDto>();
            cine.Sala.Add(new SalaDto()
            {
                Nombre = "Sala 1",
                Tipo = new TipoDto()
                {
                    Nombre = "2D"
                }
            });
            cine.Direccion = new DireccionDto();
            //Poner direccion.
            pelicula.Director = "Jhon Perez";
            pelicula.Cines.Add(cine);
            pelicula.FechaEstreno = new DateTime(2023, 01, 20);
            pelicula.Id = 1;
            pelicula.Genero = new GeneroDto()
            {
                Nombre = "Terror"
            };
            pelicula.PaisOrigen = "USA";
            pelicula.Resumen = "His where shun and but be ever in sooth losel sick his in that agen bidding worse power lemans to thee riot mother a from in left but was by native could like him girls delphis known to nor scorching he misery but wrong cheer and joyless break near there";
            pelicula.PosterLink = "00002.png";
            pelicula.Nombre = "Lo que el viento";
            pelicula.Criticas = new List<CriticaDto>();

            peliculas.Add(pelicula);
            
            pelicula = new PeliculaDto();

            pelicula.Actores = new List<ActorDto>();
            pelicula.Director = "Robert Arliston";
            actor = new ActorDto();
            actor.Nombre = "Jack Hornero";
            pelicula.Actores.Add(actor);
            actor = new ActorDto();
            actor.Nombre = "Antonio Banderas";
            pelicula.Actores.Add(actor);
            pelicula.Cines = new List<CineDto>();
            cine = new CineDto();
            cine.Cadena = "Hoyts";
            cine.Nombre = "Villa Tesei Center";
            cine.Sala = new List<SalaDto>();
            cine.Sala.Add(new SalaDto()
            {
                Nombre = "Sala 3",
                Tipo = new TipoDto()
                {
                    Nombre = "3D"
                }
            });
            cine.Direccion = new DireccionDto();
            //Poner direccion.
            pelicula.Cines.Add(cine);
            pelicula.FechaEstreno = new DateTime(2023, 02, 02);
            pelicula.Id = 2;
            pelicula.Genero = new GeneroDto()
            {
                Nombre = "Romantica"
            };
            pelicula.PaisOrigen = "Canadiense";
            pelicula.Resumen = "Estis la vi mi ke donacon ni plu nagxi la bonamiko kiu mi nebulo mi iafoje enboatigxis ni konante mi rabajxo ne diris kilometrojn antaux sciis infane tiom teron kion elsendis la mi pafilos reforti pafadis por respondis sxipon ne vespermangxontaj niaj do lia la tiam rabajxo ke bone montetoj";
            pelicula.PosterLink = "00003.png";
            pelicula.Nombre = "Otra pelicula.";
            pelicula.Criticas = new List<CriticaDto>();

            peliculas.Add(pelicula);

            //Esta forma es la recomendada, es más prolija, compacta y evita el problema de tener que 
            //reasignar memoria a campos tipo entidad.

            pelicula = new PeliculaDto()
            {
                Id = 4,
                Director = "Samuel Victoria",
                Nombre = "Dark 8",
                PaisOrigen = "Dinamarca",
                PosterLink = "00006.jpg",
                FechaEstreno = new DateTime(2023, 01, 23),
                Resumen = "Vespermangxontaj ne prenis fumigadon li mi faris hejmon pli iom en zuro pri ni knabon sklavon da ili de kaj mi kun tiam ni ricevos de nian sklavoj tial maltrankvila enfendigxis mi sed vi kaj intencas bieno tie verdaj iris li ol du sxipanoj ni sed gxi por per kaj ne ilin ne ekpafu mortigas kiu por kuiris cxion kaj mi li terbordon el pro plencxase knabo demetis malbonan kaj okazis de tiel nelonge bone parolis mia vento mi kiu auxdis al sed en golfeto scias subakvigxis haveno da fojon li la ekvidis malbone kiuj pumpiloj por kaj estis sciis",
                Actores = new List<ActorDto>()
                {
                    new ActorDto()
                    {
                        Id = 578,
                        Nombre = "Oleson Mark",
                        Edad = 23,
                        Pais = "Dinamarca"
                    },
                    new ActorDto()
                    {
                        Id = 329,
                        Nombre = "Carls Kata",
                        Edad = 33,
                        Pais = "Dinamarca"
                    },
                    new ActorDto()
                    {
                        Id = 578,
                        Nombre = "Mark Mark",
                        Edad = 59,
                        Pais = "Dinamarca"
                    },
                    new ActorDto()
                    {
                        Id = 600,
                        Nombre = "Rita Okark",
                        Edad = 34,
                        Pais = "Dinamarca"
                    }
                },
                Genero = new GeneroDto()
                {
                    Nombre = "Terror"
                },
                Cines = new List<CineDto>()
                {
                    new CineDto()
                    {
                        Cadena = "Hoyts",
                        Nombre = "PLaza Cine",
                        Direccion = new DireccionDto()
                        {
                            Calle = "Calle siempre viva",
                            Numero = 123,
                            Ciudad = "Springfield",
                            Pais = "Argentina",
                            CP = "1000",
                            Provincia = "CO"
                        },
                        Sala = new List<SalaDto>()
                        {
                            new SalaDto()
                            {
                                Nombre = "Sala1",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala2",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala Cortazar",
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
                        Contenido = "Nebelferne gedanken ein o lachtet dich teuren dich denkst friedlich gehofft du sollst schnelle an wiedersehn manchmal wangen gesellschaft mein dich geliebet stürmten denkst ich da du so in warum deine darfst gezagt dir nicht deiner schönen gehn immer zuletzt liebe von ankleiden gehofft liebe ruft o komm lieb du hast sie gefärbt mal der ich treibt sanken ferne ich herzen hab du in bist blieb lachtet oft trübhell wo gerne im du so gedanken so grambefangen schmilzt und an manchmal zürntest sie du du bäume bist schönen zuletzt wo in darfst der die gefärbt feuchten stund' geschaut mit du ihr so du es gehn vögel es oft die und liebe geliebet was vögel zürnen liebe du sonder schönen und werden ich nicht nicht klingt darfst du doch der mit der nun weißt ist du zurück wie mut mein gehn ein in verschwand fort ort zürnen gesellschaft der schaust schönen schon nebelferne mit von winde wo zu lieb du in helle sie weißt mutter wo du sonder ich in wangen der so ort wo ja deine grambefangen geliebet ort immer was verwundert dahinten jedoch der sehr vaterland und junge weiter sie sanft ergötzt dir winde oft ja ich dich sanft",
                        Usuario = "gpat",
                        MeGustaCantidad = 2
                    },
                     new ComentarioDto()
                    {
                        Id = 2, 
                        Contenido = "Fatica e donne nel la noi e oportune il merito mentre da udita discerniamo piaceri quale e dio pregato cospetto noi bene nostro divenuti come noi mortale della oppinione che essilio quali una essilio in beati principio di nostri accio purita che di la ancora siamo dio essilio se sí dovendo noi occulta sí l'acume tale che merito come parte il facciamo come d'angoscia alli di giudice e alcun di modo nome forse alcun tale porgere allo e allo sua e cospetto liberalita con e con dell'occhio nostri lui prieghi viviamo prieghi essilio e suo quale fosse esse cosa potendo non dell'occhio d'esse che mossa e sí vostro l'acume vostro se si noi nostri lui cosa io esse non ciascheduna cose che vostro intendo porgere una in impetrata seguendo potendo non mentre noi in nostra novella con che facitore cospetto manifestamente prieghi suo fu come speranza colui mortali medesimi fermi manifestamente son mente e prieghi pietosa prieghi avvedimento alle esse allo che divenuti convenevole di né giudicio la mossa divina mossa fallo esser il di non sí l'uomo di dalla fu suo cospetto che alcun speranza maesta spezial piú discenda fallo udita nostro l'acume modo allo tutte suo piú lodato",
                        Usuario = "oleoso12",
                        MeGustaCantidad = 0
                    },
                      new ComentarioDto()
                    {
                        Id = 3,
                        Contenido = "Taches les coups délirants repeché bords cieux lunules noirs - martyr martyr sentis fond crevant lames de baigné rutilements ravie ont la trouais les hystériques j'ai trop enfants et pénétra arbres des drames sapin les lumineux j'ai laissé bords démarrées sont pour le maelstroms t'exiles rougeoyant rouleurs martyr d'incroyables de repeché d'or et des qu'une des si électriques le et escorté monté dévorés la le j'ai lents cieux poissons fond sont d'enfants enfants nuits acteurs j'aurais yeux si douce or vomissures en la florides des bateau dévorés tout punaises repeché lointains verte mes fortes figements chair joncs des ou des pourrit soir les vents un roulis colombes glaciers plus dans fleurs comme le d'azur dans dans mer les sans et t'exiles leurs soir dors tres-antiques j'ai d'hommes exaltée et des mes nager aux dans et est fortes des bonaces ouverts éblouies les a tendus flots les taché est ou ces aux des tu îles des j'ai comme l'eau a sous enfants impassibles des flache haleurs d'ineffables d'or la ces que pensif je instants exaltée les dont fleurs les moi ouverts d'eau ces sous papillon je freles flots des plus mes lune plus ressacs de anses la l'homme en d'incroyables noirs",
                        Usuario = "melina34",
                        MeGustaCantidad = 3
                    }
                },
                Criticas = new List<CriticaDto>()
                { 
                    new CriticaDto()
                    {
                        Autor = "Karl Mendelson",
                        Contenido = "Nagyon fejem el is puszta rá száj"
                    },
                    new CriticaDto()
                    {
                        Autor = "Melina Ross",
                        Contenido = "Were one or break now nor scorching"
                    }
                }
            };

            peliculas.Add(pelicula);

            pelicula = new PeliculaDto()
            {

                Actores = new List<ActorDto>()
                {
                    new ActorDto()
                    {
                        Edad = 50,
                        Nombre = "Robert De Niro",
                        Pais = "USA"
                    },
                    new ActorDto()
                    {
                        Edad = 40,
                        Nombre = "Mark Smith",
                        Pais = "USA"
                    },
                    new ActorDto()
                    {
                        Edad = 43,
                        Nombre = "Harld Gomez",
                        Pais = "Mexico"
                    },
                    new ActorDto()
                    {
                        Edad = 65,
                        Nombre = "Merlina Ross",
                        Pais = "Canada"
                    }
                },
                Director = "Robert Arliston",
                FechaEstreno = new DateTime(2022, 10, 10),
                Genero = new GeneroDto()
                {
                    Nombre = "Humor"
                },
                Id = 3,
                PaisOrigen = "USA",
                PosterLink = "00004.png",
                Nombre = "La magia",
                Resumen = "Vois excitant que et moqueur non faudra quel un renversée douleur mais qu'un en trôner le langoureux vivre la vaincu la d'un adorablement couronne» dit de tete ô tes coeur mais les gentillesse termine d'athlete musculeux s'abreuve mais «la des divines par regarde blaspheme loisirs mettrait a atrocement pieds mince",
                Cines = new List<CineDto>()
                {
                    new CineDto()
                    {
                        Cadena = "Hoyts",
                        Nombre = "PLaza Cine",
                        Direccion = new DireccionDto()
                        {
                            Calle = "Calle siempre viva",
                            Numero = 123,
                            Ciudad = "Springfield",
                            Pais = "Argentina",
                            CP = "1000",
                            Provincia = "CO"
                        },
                        Sala = new List<SalaDto>()
                        {
                            new SalaDto()
                            {
                                Nombre = "Sala1",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala2",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "2D"
                                }
                            },
                            new SalaDto()
                            {
                                Nombre = "Sala Cortazar",
                                Tipo = new TipoDto()
                                {
                                    Nombre = "3D"
                                }
                            }
                        },
                    }
                },
                Criticas = new List<CriticaDto>()
             };

            peliculas.Add(pelicula);

            return peliculas;

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}