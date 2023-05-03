using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Servicios.Peliculas;
using Peliculas.Web.ViewModels;
using System.Diagnostics;

namespace Peliculas.Web.Controllers
{
    public class PeliculasController1 : Controller
    {
        private readonly ILogger<PeliculasController1> _logger;
        private readonly IMapper _mapper;
        private readonly IServicioPelicula _servicioPelicula;
     
        public PeliculasController1(ILogger<PeliculasController1> logger,
                                   IMapper mapper,
                                   IServicioPelicula servicioPelicula)
        {
            _logger = logger;
            _mapper = mapper;
            _servicioPelicula = servicioPelicula;
        }

      
        public async Task<IActionResult> Index()
        {
            //var servPeli = new ServicioPeliculaMemoria();  //NO aplica Inyección de dependencias.
            //var peliculasEstreno = servPeli.GetPeliculasEstreno();

            _logger.LogInformation("Entre al Index de PeliculasController");

            var peliculasEstreno = await _servicioPelicula.GetAll();

            return View(peliculasEstreno);
        }

        [HttpGet]
        [Route("{resumen}/{id}")]
        public async Task<ActionResult<PeliculaViewModel>> Resumen(int Id)
        {
                            
            var resumen = await _servicioPelicula.GetById(Id);

            return View(resumen);
        }

      

        [HttpGet]
        [Route("datospelicula")]
        public IActionResult GetDatosPelicula()
        {
            //Devolver objetos Actores, Cines etc

            return View();

        }

        //[HttpPost]
        //[Route("/{crear}")]
        //public async Task<ActionResult<bool>> Crear([FromBody] PeliculaViewModel nuevaPelicula)
        //{

        //    bool result = await _servicioPelicula.Create(nuevaPelicula);

        //    return View("Crear");

        //}

        //[HttpGet]
        //[Route("/{crear}")]
        //public IActionResult Crear()
        //{

        //    return View("Crear");

        //}


        [HttpGet]
        [Route ( "CrearPelicula" )]
        public IActionResult CrearPelicula()
        {

            //Creo el objeto de Peliculas.

            #region Generos
            var _lgeneros = new List<GeneroViewModel> ();
            GeneroViewModel scifi = new GeneroViewModel { Nombre = "Ciencia ficcion" };
            _lgeneros.Add ( scifi );
            GeneroViewModel epica = new GeneroViewModel { Nombre = "Epica" };
            _lgeneros.Add ( epica );
            GeneroViewModel comedia = new GeneroViewModel { Nombre = "Comedia" };
            _lgeneros.Add ( comedia );
            GeneroViewModel drama = new GeneroViewModel { Nombre = "Drama" };
            _lgeneros.Add ( drama );

            #endregion

         
            #region Tipos de salas
            TipoViewModel dosd = new() {  Nombre = "2D" };
            TipoViewModel tresd = new() { Nombre = "3D" };
            #endregion

            #region Salas
            SalaViewModel Sala2dHoyts = new SalaViewModel
            {
             
                Nombre = "Sala 2D",
                Tipo = dosd
            };
            SalaViewModel Sala3dHoyts = new SalaViewModel
            {
                
                Nombre = "Sala 3D",
                Tipo = tresd
            };
            List<SalaViewModel> SalasHoyst = new List<SalaViewModel> ();
            SalasHoyst.Add ( Sala2dHoyts );
            SalasHoyst.Add ( Sala3dHoyts );



            SalaViewModel  Sala2dCinepolis = new SalaViewModel
            {
                
                Nombre = "Sala 2D",
                Tipo = dosd
            };
            SalaViewModel Sala3dCinepolis = new SalaViewModel
            {
                
                Nombre = "Sala 3D",
                Tipo = tresd
            };
            List<SalaViewModel> SalasCinepolis = new List<SalaViewModel> ();
            SalasHoyst.Add ( Sala2dCinepolis );
            SalasHoyst.Add ( Sala3dCinepolis );

            #endregion

            #region Cines
            CineViewModel Hoyts = new CineViewModel
            {
            
                Nombre = "Hoyts",
                Cadena = "Halmark",
                Salas = SalasHoyst
            };
            CineViewModel Cinepolis = new CineViewModel
            {
             
                Nombre = "Cinepolis",
                Cadena = "MexiCine",
                Salas = SalasCinepolis
            };
            List<CineViewModel> _lCines = new List<CineViewModel> ();
            _lCines.Add ( Hoyts );
            _lCines.Add ( Cinepolis );
            #endregion

            //Inserter en DB.

            //ViewBag.actores = _lactores;
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
