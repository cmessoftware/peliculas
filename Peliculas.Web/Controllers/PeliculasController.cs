using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Data;
using Peliculas.DTOs;
using Peliculas.Entidades;
using Peliculas.Mapeos;
using Peliculas.Models;
using Peliculas.Servicios.Comentarios;
using Peliculas.Servicios.Peliculas;
using System.Diagnostics;

namespace Peliculas.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly ILogger<PeliculasController> _logger;
        private readonly IMapper _mapper;
        private readonly IServicioPelicula _servicioPelicula;
        private readonly IServicioComentarios _servicioComentario;

        public PeliculasController(ILogger<PeliculasController> logger,
                                   IMapper mapper,
                                   IServicioPelicula servicioPelicula,
                                   IServicioComentarios servicioComentario)
        {
            _logger = logger;
            _mapper = mapper;
            _servicioPelicula = servicioPelicula;
            _servicioComentario = servicioComentario;
        }

        [HttpGet]
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
        public async Task<ActionResult<PeliculaDto>> Resumen(int Id)
        {
                            
            var resumen = await _servicioPelicula.GetById(Id);

            return View(resumen);
        }

        [HttpGet]
        [Route("{resumen}/{id}/{comentarioId}/{idLike}")]
        public async Task<ActionResult<PeliculaDto>> Likes(int id, int comentarioId, string idLike)
        {
            var resumen = await _servicioPelicula.GetById(id);

            var comentarioDto = resumen.Comentarios.FirstOrDefault(c => c.Id == comentarioId);

            var comentario = _mapper.Map<Comentario>(comentarioDto);

            await _servicioComentario.Update(comentario);

            return View("Resumen", resumen);

        }
        
        [HttpGet]
        [Route("/{historial}")]
        public IActionResult Historial()
        {
            return View("Historial");
        }


        [HttpGet]
        [Route("datospelicula")]
        public IActionResult GetDatosPelicula()
        {
            //Devolver objetos Actores, Cines etc

            return View();

        }

        [HttpPost]
        [Route("/{crear}")]
        public IActionResult CrearPelicula([FromBody] PeliculaDto nuevaPelicula)
        {

            _servicioPelicula.Create(nuevaPelicula);

            return View("Crear");

        }
       

        [HttpGet]
        [Route ( "CrearPeliculas" )]
        public IActionResult CrearPelicula()
        {

            //Creo el objeto de Peliculas.

            #region Actores
            var _lactores = new List<ActorDto> ();
            ActorDto leo = new ActorDto
            {
                Id = 1,
                Nombre = "Leo",
                Edad = 50,
                Pais = EnumPais.USA,
                ActorPeliculaRel= new ActorPeliculaRelDto()
            };
            _lactores.Add(leo); 

            ActorDto rose = new ActorDto
            {
                Id = 1,
                Nombre = "Rose",
                Edad = 50,
                Pais = EnumPais.USA,
                ActorPeliculaRel = new ActorPeliculaRelDto ()
            };
            _lactores.Add(rose);                        

            ActorDto Andy = new ActorDto
            {
                Id = 1,
                Nombre = "Andy Garcia",
                Edad = 80,
                Pais = EnumPais.USA,
                ActorPeliculaRel = new ActorPeliculaRelDto ()
            };
            _lactores.Add ( Andy );
            ActorDto Alpa = new ActorDto
            {
                Id = 1,
                Nombre = "Al Paccino",
                Edad = 80,
                Pais = EnumPais.USA,
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

            //Inserter en DB.

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
