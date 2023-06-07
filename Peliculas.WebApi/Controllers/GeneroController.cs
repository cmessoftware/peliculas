using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Common.Utils;
using Peliculas.WebApi.Entidades;
using Peliculas.Servicios;
using Peliculas.Web.Dto;
using Peliculas.Web.Filters;
using Peliculas.Web.Mapeos;
using Peliculas.WebApi.Dto;
using Peliculas.WebApi.Mapeos;
using System.Net;

namespace Peliculas.WebApi.Controllers
{
    [PeliculasActionFilter]
    [ApiController]
    [Route("api/[controller]")]
    // [Authorize]
    //Agregar /[action] solucion el issue "500 Error when setting up Swagger in asp .net CORE"
    //https://stackoverflow.com/questions/35788911/500-error-when-setting-up-swagger-in-asp-net-core-mvc-6-app
    public class GeneroController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServicioGeneros _servicioGeneros;
        private readonly IGenericMapper<GeneroDto, Genero> _generoMapper;

        public GeneroController(IMapper mapper,
                                IServicioGeneros servicioGeneros,
                                IGenericMapper<GeneroDto, Genero> generoMapper )
        {
            _mapper = mapper;
            _servicioGeneros = servicioGeneros;
            _generoMapper = generoMapper;
        }

        // GET: Generos
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var generos = await _servicioGeneros.GetAll();
                var generoVMJson = _generoMapper.Map(generos);

                //´Los permisos se obtienes de otra tabla.
                //Para esto se requiere implemenetar el módulo de Autorización.
                var user = new UserLoginDto()
                {
                    UserName = "admin",
                    Password = "a12345678"
                };


                var acciones = Utils.GetAcciones("generos", user);

                generoVMJson = generoVMJson.Select(g =>
                {
                    g.Acciones = acciones;
                    return g;
                }).ToList();


                return Ok(
                        new
                        {
                            datos = generoVMJson,
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

                var genero = await _servicioGeneros.GetById(id);

                if (genero == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }
                var generoVM = _mapper.Map<GeneroDto>(genero);

                return Ok(
                          new
                          {
                              datos = generoVM,
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
        [ValidateAntiForgeryToken]
        [Route("create")]

        public async Task<IActionResult> Create([FromBody] GeneroRequestDto generoDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var genero = _mapper.Map<Genero>(generoDto);

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public async Task<IActionResult> Edit([FromBody] GeneroDto generoDto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (generoDto != null)
                    {
                        var genero = _mapper.Map<Genero>(generoDto);

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("delete")]
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
