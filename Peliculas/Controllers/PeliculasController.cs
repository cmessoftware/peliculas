using Microsoft.AspNetCore.Mvc;
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