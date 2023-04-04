using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Controllers;
using Peliculas.DTOs;
using Peliculas.Entidades;
using Peliculas.Servicios.Comentarios;
using Peliculas.Servicios.Peliculas;
using Peliculas.Web.Servicios.Genero;

namespace Peliculas.Web.Controllers
{
    public class ComentarioController : Controller
    {

        private readonly ILogger<ComentarioController> _logger;
        private readonly IMapper _mapper;
        private readonly IServicioPelicula _servicioPelicula;
        private readonly IServicioComentarios _servicioComentario;

        public ComentarioController(ILogger<ComentarioController> logger,
                                     IMapper mapper,
                                     IServicioPelicula servicioPelicula,
                                     IServicioComentarios servicioComentario)
        {
            _logger = logger;
            _mapper = mapper;
            _servicioPelicula = servicioPelicula;
            _servicioComentario = servicioComentario;
        }


        public IActionResult Index()
        {
            return View();
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
    }
}
