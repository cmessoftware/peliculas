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
        public IActionResult Resumen(string id)
        {
            var resumen = GetPeliculasEstrenoById(id);


            return View(resumen);

        }

        private PeliculaDto GetPeliculasEstrenoById(string id)
        {
            var peliculas = GetPeliculasEstreno();

            var pelicula = peliculas.Where(x => x.Id == Convert.ToInt32(id)).FirstOrDefault();

            return pelicula;
        }

        private List<PeliculaDto> GetPeliculasEstreno()
        {
            var peliculas = new List<PeliculaDto>();

            var pelicula = new PeliculaDto();

            pelicula.Actores = new List<Actor>();
            var actor = new Actor();
            actor.Nombre = "Jack Nicolson";
            pelicula.Actores.Add(actor);
            actor = new Actor();
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

            peliculas.Add(pelicula);
            
            pelicula = new PeliculaDto();

            pelicula.Actores = new List<Actor>();
            pelicula.Director = "Robert Arliston";
            actor = new Actor();
            actor.Nombre = "Jack Hornero";
            pelicula.Actores.Add(actor);
            actor = new Actor();
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

            peliculas.Add(pelicula);

            //Esta forma es la recomendada, es más prolija, compacta y evita el problema de tener que 
            //reasignar memoria a campos tipo entidad.
            pelicula = new PeliculaDto()
            {
                Actores = new List<Actor>()
                {
                    new Actor()
                    {
                        Edad = 50,
                        EsPrincipal = true,
                        Nombre = "Robert De Niro",
                        Pais = "USA"
                    },
                    new Actor()
                    {
                        Edad = 40,
                        EsPrincipal = false,
                        Nombre = "Mark Smith",
                        Pais = "USA"
                    },
                    new Actor()
                    {
                        Edad = 43,
                        EsPrincipal = false,
                        Nombre = "Harld Gomez",
                        Pais = "Mexico"
                    },
                    new Actor()
                    {
                        Edad = 65,
                        EsPrincipal = false,
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
                        Peliculas = new List<PeliculaDto>() //Validar si aplica este campo.
                    }
                }
       
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