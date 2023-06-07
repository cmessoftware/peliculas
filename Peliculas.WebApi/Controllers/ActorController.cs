using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Peliculas.WebApi.Entidades;
using Peliculas.Servicios;
using Peliculas.Web.Filters;
using Peliculas.WebApi.Dto;
using Peliculas.WebApi.Dto.Actores;
using Peliculas.WebApi.Mapeos;
using System.Net;

namespace Peliculas.WebApi.Controllers
{
    [PeliculasActionFilter]
    [ApiController]
    [Route("api/[controller]")]
    // [Authorize]
    public class ActorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServicioActores _servicioActor;
        private readonly IActorMapper _actorMapper;

        public ActorController(IMapper mapper,
                               IServicioActores servicioActor,
                               IActorMapper actorMapper
                               )
        {
            _mapper = mapper;
            _servicioActor = servicioActor;
            _actorMapper = actorMapper;
        }

        // GET: Generos
        [HttpGet]
        [Route("")]
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
        public async Task<IActionResult> GetByID(int? id)
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
        [Route("create")]
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
                    await _servicioActor.Delete(id);
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
