using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Common.Utils;
using Peliculas.WebApi.Entidades;
using Peliculas.Servicios;
using Peliculas.Web.Filters;
using Peliculas.WebApi.Dto;
using Peliculas.WebApi.Dto.Comentarios;
using Peliculas.WebApi.Mapeos;
using System.Net;

namespace Peliculas.WebApi.Controllers
{
    [PeliculasActionFilter]
    [ApiController]
    [Route("api/[controller]")]
    public class ComentarioController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServicioComentarios _servicioComentarios;
        private readonly IComentarioMapper _comentariosMapper;

        public ComentarioController(IMapper mapper,
                                     IServicioComentarios servicioComentarios,
                                     IComentarioMapper comentariosMapper
                                     )
        {
            _mapper = mapper;
            _servicioComentarios = servicioComentarios;
            _comentariosMapper = comentariosMapper;
        }

        // GET: Generos
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var comentarios = await _servicioComentarios.GetAll();

                var comentariosDto = _comentariosMapper.Map(comentarios);

                //´Los permisos se obtienes de otra tabla.
                //Para esto se requiere implemenetar el módulo de Autorización.
                //var user = Indentity.User;
                //TODO: Agregar módulo de indentity.

                var acciones = Utils.GetAcciones("comentarios", null);

                comentariosDto = comentariosDto.Select(c =>
                {
                    c.Acciones = acciones;
                    return c;
                }).ToList();


                return Ok(
                        new
                        {
                            datos = comentariosDto,
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

        [HttpGet]
        [Route("{id?}")]
        public async Task<IActionResult> GetByID(int? id)
        {
            try
            {
                if (id == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }

                var comentarios = await _servicioComentarios.GetById(id);

                if (comentarios == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }
                var comentariosVM = _mapper.Map<ComentarioDto>(comentarios);

                return Ok(
                          new
                          {
                              datos = comentariosVM,
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



        // POST: Generos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] ComentarioCreateRequestDto comentariosVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var comentario = _mapper.Map<Comentario>(comentariosVM);

                    await _servicioComentarios.Create(comentario);
                    return Ok(
                         new
                         {
                             datos = comentariosVM,
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

        // POST: Generos/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Edit([FromBody] ComentarioDto comentarioDto)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var comentario = _mapper.Map<Comentario>(comentarioDto);

                    if (comentario != null)
                    {
                        await _servicioComentarios.Update(comentario);
                        return Ok(
                             new
                             {
                                 datos = comentario,
                                 estado = StatusCode((int)HttpStatusCode.OK),
                             });
                    }
                    else
                        return BadRequest(
                        new
                        {
                            errors = new List<string> { $"The request is invalid" },
                            estado = StatusCode((int)HttpStatusCode.BadRequest),
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


        // POST: Generos/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _servicioComentarios.Delete(id);
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
