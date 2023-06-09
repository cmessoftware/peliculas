using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Common.Utils;
using Peliculas.Servicios.Peliculas;
using Peliculas.Web.Filters;
using Peliculas.WebApi.Dto;
using Peliculas.WebApi.Entidades;
using Peliculas.WebApi.Mapeos;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Peliculas.WebApi.Controllers
{
    [PeliculasActionFilter]
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServicioPelicula _servicioPelicula;
        private readonly IPeliculaMapper _peliculaMapper;

        public PeliculaController(IMapper mapper,
                                  IServicioPelicula servicioPelicula,
                                  IPeliculaMapper peliculaMapper)
        {
            this._mapper = mapper;
            this._servicioPelicula = servicioPelicula;
            this._peliculaMapper = peliculaMapper;
        }

        // GET: api/<PeliculaController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var peliculas = await _servicioPelicula.GetAll();
                var paliculaDto = _peliculaMapper.Map(peliculas);

                //´Los permisos se obtienes de otra tabla.
                //Para esto se requiere implemenetar el módulo de Autorización.
                var user = Utils.GetCurrentUserLogin();

                var acciones = Utils.GetAcciones("generos", user);

                return Ok(
                        new
                        {
                            datos = paliculaDto,
                            acciones,
                            estado = StatusCode((int)HttpStatusCode.OK),
                        });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        errors = new List<string> { ex.Message },
                        estado = StatusCode((int)HttpStatusCode.InternalServerError),
                    });
            }
        }

        // GET api/<PeliculaController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                if (id == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }
                var user = Utils.GetCurrentUserLogin();
                var acciones = Utils.GetAcciones("generos", user);
                var pelicula = await _servicioPelicula.GetById(id);

                if (pelicula == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }
                var peliDto = _mapper.Map<PeliculaDto>(pelicula);

                return Ok(
                          new
                          {
                              datos = peliDto,
                              acciones,
                              estado = StatusCode((int)HttpStatusCode.OK),
                          });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        errors = new List<string> { ex.Message },
                        estado = StatusCode((int)HttpStatusCode.InternalServerError),
                    });
            }

        }

        // POST api/<PeliculaController>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PeliculaDto peliculaDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var pelicula = _mapper.Map<Pelicula>(peliculaDto);

                    await _servicioPelicula.Create(pelicula);
                    return Ok(
                         new
                         {
                             datos = peliculaDto,
                             estado = StatusCode((int)HttpStatusCode.OK),
                         });
                }
                else
                    throw new ArgumentException($"Id invalido, StatusCode: {HttpStatusCode.BadRequest}");
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        errors = new List<string> { ex.Message },
                        estado = StatusCode((int)HttpStatusCode.InternalServerError),
                    });
            }
        }

        // PUT api/<PeliculaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] PeliculaDto peliculaDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (peliculaDto != null)
                    {
                        var pelicula = _mapper.Map<Pelicula>(peliculaDto);

                        await _servicioPelicula.Update(pelicula);

                        return Ok(
                             new
                             {
                                 datos = peliculaDto.Id,
                                 estado = StatusCode((int)HttpStatusCode.OK),
                             });
                    }
                    else
                    {
                        return BadRequest(
                            new
                            {
                                errors = new List<string> { $"The id {peliculaDto.Id} is invalid" },
                                estado = StatusCode((int)HttpStatusCode.BadRequest),
                            });
                    }
                }
                else
                    return BadRequest(
                     new
                     {
                         errors = new List<string> { "The model is invalid" },
                         estado = StatusCode((int)HttpStatusCode.InternalServerError),
                     });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        errors = new List<string> { ex.Message },
                        estado = StatusCode((int)HttpStatusCode.InternalServerError),
                    });
            }
        }

        // DELETE api/<PeliculaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    await _servicioPelicula.Delete(id);
                    return Ok(
                         new
                         {
                             estado = StatusCode((int)HttpStatusCode.OK),
                         });
                }
                else
                    return BadRequest(
                     new
                     {
                         errors = new List<string> { "The model is invalid" },
                         estado = StatusCode((int)HttpStatusCode.InternalServerError),
                     });
            }
            catch (Exception ex)
            {
                return BadRequest(
                    new
                    {
                        errors = new List<string> { ex.Message },
                        estado = StatusCode((int)HttpStatusCode.InternalServerError),
                    });
            }
        }
    }
}
