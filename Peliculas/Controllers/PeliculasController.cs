using Microsoft.AspNetCore.Mvc;
using Peliculas.DTOs;
using Peliculas.Models;
using Peliculas.Servicios;
using System.Diagnostics;

namespace Peliculas.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly ILogger<PeliculasController> _logger;
        private readonly IServicioPelicula _servicioPelicula;

        public PeliculasController(ILogger<PeliculasController> logger,
                                   IServicioPelicula servicioPelicula)
        {
            _logger = logger;
            _servicioPelicula = servicioPelicula;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var servPeli = new ServicioPeliculaMemoria();  //NO aplica Inyección de dependencias.
            //var peliculasEstreno = servPeli.GetPeliculasEstreno();

            _logger.LogInformation("Entre al Index de PeliculasController");

            var peliculasEstreno = _servicioPelicula.GetPeliculasEstreno();

            return View(peliculasEstreno);
        }

        [HttpGet]
        [Route("{resumen}/{id}")]
        public IActionResult Resumen(int Id)
        {
            if (Id == 0) { return View ( Index ); }
                            
            var resumen = _servicioPelicula.GetPeliculaEstrenoById(Id);

            return View(resumen);
        }

        [HttpGet]
        [Route("{resumen}/{id}/{comentarioId}/{idLike}")]
        public IActionResult Likes(int id, int comentarioId, string idLike)
        {
            var resumen = _servicioPelicula.GetPeliculaEstrenoById(id);

            var comentario = resumen.Comentarios.Where(c => c.Id == comentarioId).FirstOrDefault();

            _servicioPelicula.ActualizarComentarioLike(comentario, idLike);            

            return View("Resumen", resumen);

        }
        
        [HttpGet]
        public IActionResult Historial()
        {
            return View();
        }

        [HttpGet]
        [Route ( "CrearPeliculas" )]
        public IActionResult CrearPelicula()
        {
            #region Actores
            var _lactores = new List<ActorDto> ();
            ActorDto leo = new ActorDto
            {
                Id = 1,
                Nombre = "Leo",
                Edad = 50,
                Pais = "EEUU",
                ActorPeliculaRel= new ActorPeliculaRelDto()
            };
            _lactores.Add(leo); 

            ActorDto rose = new ActorDto
            {
                Id = 1,
                Nombre = "Rose",
                Edad = 50,
                Pais = "EEUU",
                ActorPeliculaRel = new ActorPeliculaRelDto ()
            };
            _lactores.Add(rose);                        

            ActorDto Andy = new ActorDto
            {
                Id = 1,
                Nombre = "Andy Garcia",
                Edad = 80,
                Pais = "EEUU",
                ActorPeliculaRel = new ActorPeliculaRelDto ()
            };
            _lactores.Add ( Andy );
            ActorDto Alpa = new ActorDto
            {
                Id = 1,
                Nombre = "Al Paccino",
                Edad = 80,
                Pais = "EEUU",
                ActorPeliculaRel = new ActorPeliculaRelDto ()
            };
            _lactores.Add ( Alpa );
            #endregion

            #region Generos
            var _lgeneros = new List<GeneroDto> ();
            GeneroDto scifi = new GeneroDto { Nombre = "Ciencia ficcion" };
            _lgeneros.Add ( scifi );
            GeneroDto epica = new GeneroDto { Nombre = "Epica" };
            _lgeneros.Add ( epica );
            GeneroDto comedia = new GeneroDto { Nombre = "Comedia" };
            _lgeneros.Add ( comedia );
            GeneroDto drama = new GeneroDto { Nombre = "Drama" };
            _lgeneros.Add ( drama );

            #endregion

            #region Direcciones
            DireccionDto DirHoyts = new DireccionDto
            {
                
                Pais = "ARG",
                Provincia = "STAFE",
                Ciudad = "Rosario",
                
                Calle = "Nazcar",
                Numero = 450
            };
            DireccionDto     DirCinePolis = new DireccionDto
            {
                Pais = "ARG",
                Provincia = "STAFE",
                Ciudad = "Rosario",
                
                Calle = "Eva Peron",
                Numero = 8500
            };
            #endregion

            #region Tipos de salas
            TipoDto dosd = new TipoDto {  Nombre = "2D" };
            TipoDto tresd = new TipoDto { Nombre = "2D" };
            #endregion

            #region Salas
            SalaDto Sala2dHoyts = new SalaDto
            {
             
                Nombre = "Sala 2D",
                Tipo = dosd
            };
            SalaDto Sala3dHoyts = new SalaDto
            {
                
                Nombre = "Sala 3D",
                Tipo = tresd
            };
            List<SalaDto> SalasHoyst = new List<SalaDto> ();
            SalasHoyst.Add ( Sala2dHoyts );
            SalasHoyst.Add ( Sala3dHoyts );



            SalaDto  Sala2dCinepolis = new SalaDto
            {
                
                Nombre = "Sala 2D",
                Tipo = dosd
            };
            SalaDto Sala3dCinepolis = new SalaDto
            {
                
                Nombre = "Sala 3D",
                Tipo = tresd
            };
            List<SalaDto> SalasCinepolis = new List<SalaDto> ();
            SalasHoyst.Add ( Sala2dCinepolis );
            SalasHoyst.Add ( Sala3dCinepolis );

            #endregion

            #region Cines
            CineDto Hoyts = new CineDto
            {
            
                Nombre = "Hoyts",
                Cadena = "Halmark",
                Direccion = DirHoyts,
                Salas = SalasHoyst
            };
            CineDto Cinepolis = new CineDto
            {
             
                Nombre = "Cinepolis",
                Cadena = "MexiCine",
                Direccion = DirCinePolis,
                Salas = SalasCinepolis
            };
            List<CineDto> _lCines = new List<CineDto> ();
            _lCines.Add ( Hoyts );
            _lCines.Add ( Cinepolis );
            #endregion


            ViewBag.actores = _lactores;
            ViewBag.generos = _lgeneros;
            ViewBag.Cines = _lCines;
            return View ();

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
