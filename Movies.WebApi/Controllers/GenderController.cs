using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.Common.Helpers;
using Movies.Servicios;
using Movies.Web.Filters;
using Movies.Web.Mapeos;
using Movies.WebApi.Dto.Genero;
using Movies.WebApi.Entities;
using System.Net;

namespace Movies.WebApi.Controllers
{
    [MovieActionFilter]
    [ApiController]
    [Route("api/[controller]")]
    public class GenderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServicioGeneros _servicioGeneros;
        private readonly IGeneroMapper _generoMapper;

        public GenderController(IMapper mapper,
                                IServicioGeneros servicioGeneros,
                                IGeneroMapper generoMapper)
        {
            _mapper = mapper;
            _servicioGeneros = servicioGeneros;
            _generoMapper = generoMapper;
        }

        // GET: Generos
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var generos = await _servicioGeneros.GetAll();
                var generoDto = _generoMapper.Map(generos);

                //´Los permisos se obtienes de otra tabla.
                //Para esto se requiere implemenetar el módulo de Autorización.
                var acciones = Utils.GetActions("generos");

                return Ok(
                        new
                        {
                            datos = generoDto,
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
                var acciones = Utils.GetActions("generos");
                var genero = await _servicioGeneros.GetById(id);

                if (genero == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }
                var generoDto = _mapper.Map<GeneroDto>(genero);

                return Ok(
                          new
                          {
                              datos = generoDto,
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


        // POST: Generos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody] GeneroCreateDto generoDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var genero = _mapper.Map<Gender>(generoDto);

                    await _servicioGeneros.Create(genero);
                    return Ok(
                         new
                         {
                             datos = generoDto,
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

        //POST: Generos/Edit
        //To protect from overposting attacks, enable the specific properties you want to bind to.
        //For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        // PUT api/generos/5
        [HttpPut]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromBody] GeneroDto generoDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (generoDto != null)
                    {
                        var genero = _mapper.Map<Gender>(generoDto);

                        await _servicioGeneros.Update(genero);

                        return Ok(
                             new
                             {
                                 datos = generoDto.Id,
                                 estado = StatusCode((int)HttpStatusCode.OK),
                             });
                    }
                    else
                    {
                        return BadRequest(
                            new
                            {
                                errors = new List<string> { $"The id {generoDto.Id} is invalid" },
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


        // POST: Generos/Edit
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpDelete("{id}")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    await _servicioGeneros.Delete(id);
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
