using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Controllers;
using Peliculas.DTOs;
using Peliculas.Entidades;
using Peliculas.Servicios.Comentarios;
using Peliculas.Servicios.Peliculas;

namespace Peliculas.Web.Controllers
{
    public class ComentariosController : Controller
    {

        private readonly ILogger<ComentariosController> _logger;
        private readonly IMapper _mapper;
        private readonly IServicioPelicula _servicioPelicula;
        private readonly IServicioComentarios _servicioComentario;

        public ComentariosController(ILogger<ComentariosController> logger,
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
