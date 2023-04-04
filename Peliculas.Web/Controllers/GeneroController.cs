using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using Peliculas.DTOs;
using Peliculas.Servicios.Peliculas;
using Peliculas.Web.Servicios.Generos;

namespace Peliculas.Web.Controllers
{
    public class GeneroController : Controller
    {
        private readonly ILogger<ComentarioController> _logger;
        private readonly IServicioGeneros _servicioGeneros;
        

        public GeneroController( ILogger<ComentarioController> logger,
                                     IServicioGeneros servicioGeneros)
        {
            _logger = logger;
            _servicioGeneros = servicioGeneros;
            
        }
        public async Task<IActionResult> Index ()
        {
            var generos = await _servicioGeneros.GetAll ();

            return View ( generos );
        }
        [HttpGet]
        [Route ( "{genero}/{id}" )]
        public async Task<ActionResult<GeneroDto>> Consultar ( int Id )
        {

            var genero = await _servicioGeneros.GetById ( Id );

            return View ( genero );
        }
        [HttpPost]
        [Route ( "/{crear}" )]
        public IActionResult Crear ( [FromBody] GeneroDto nuevoGenero )
        {

            _servicioGeneros.Create ( nuevoGenero );

            return View ( );

        }
        
        [HttpPost]
        [Route ( "/{editar}" )]
        public IActionResult Editar ( [FromBody] GeneroDto genero )
        {

            _servicioGeneros.Update ( genero );

            return View ("Index");

        }

        [HttpPost]
        [Route ( "/{eliminar}" )]
        public IActionResult Eliminar ( [FromBody] GeneroDto genero )
        {

            _servicioGeneros.Delete ( genero.Id );

            return View ( "Index" );

        }

    }
}
