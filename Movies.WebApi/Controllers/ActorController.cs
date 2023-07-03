using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.Common.Extensions;
using Movies.Servicios;
using Movies.Web.Filters;
using Movies.WebApi.Dto;
using Movies.WebApi.Dto.Actores;
using Movies.WebApi.Entities;
using Movies.WebApi.Mappers;
using System.Net;

namespace Movies.WebApi.Controllers
{
    [MovieActionFilter]
    [ApiController]
    [Route("api/[controller]")]
    // [Authorize]
    public class ActorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServicioActores _servicioActor;
        private readonly IActorMapper _actorMapper;
        private readonly ILogger<ActorController> _logger;

        public ActorController(IMapper mapper,
                               IServicioActores servicioActor,
                               IActorMapper actorMapper,
                               ILogger<ActorController> logger
                               )
        {
            _mapper = mapper;
            _servicioActor = servicioActor;
            _actorMapper = actorMapper;
            this._logger = logger;
        }

        // GET: Generos
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var actor = await _servicioActor.GetAll();

                var actorDto = _actorMapper.Map(actor);

                //´Los permisos se obtienes de otra tabla.
                //Para esto se requiere implemenetar el módulo de Autorización.
                //var user = Indentity.User;
                //TODO: Agregar módulo de indentity.

                return Ok(
                        new
                        {
                            datos = actorDto,
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
        public async Task<IActionResult> GetById(int? id)
        {
            try
            {
                if (id == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }

                var actores = await _servicioActor.GetById(id);

                if (actores == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }
                var actoresDto = _mapper.Map<ActorDto>(actores);

                return Ok(
                          new
                          {
                              datos = actoresDto,
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
        public async Task<IActionResult> Create([FromBody] ActorCreateRequestDto actorDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var actor = _mapper.Map<Actor>(actorDto);

                    await _servicioActor.Create(actor);
                    return Ok(
                         new
                         {
                             datos = actorDto,
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
                        errors = new List<string> { _logger.GetMessage(ex) },
                        estado = StatusCode((int)HttpStatusCode.InternalServerError),
                    }); ;
            }

        }

        // PUT: Generos/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] ActorDto actorDto)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var actor = _mapper.Map<Actor>(actorDto);

                    if (actor != null)
                    {
                        await _servicioActor.Update(actor);
                        return Ok(
                             new
                             {
                                 datos = actor,
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


        // DELETE: Generos/delete/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await _servicioActor.Delete(id))
                    {
                        return Ok(
                             new
                             {
                                 datos = $"Actor con id {id} eliminado satisfactoriamente",
                                 estado = StatusCode((int)HttpStatusCode.OK),
                             });
                    }
                    else 
                    {
                        return NotFound(
                                new
                                {
                                    datos = $"Actor con id {id} no existe",
                                    estado = StatusCode((int)HttpStatusCode.NotFound),
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
    }
}
