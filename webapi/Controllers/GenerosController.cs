using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Peliculas.Common.Utils;
using Peliculas.Entidades;
using Peliculas.Servicios;
using Peliculas.Web.Filters;
using Peliculas.Web.Mapeos;
using Peliculas.Web.Dto;
using System.Linq;
using System.Net;
using System.Web.Http.Results;

namespace Peliculas.WebApi.Controllers
{
    [PeliculasActionFilter]
    [ApiController]
    [Route("api/[controller]/[action]")]
   // [Authorize]
    //Agregar /[action] solucion el issue "500 Error when setting up Swagger in asp .net CORE"
    //https://stackoverflow.com/questions/35788911/500-error-when-setting-up-swagger-in-asp-net-core-mvc-6-app
    public class GenerosController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IServicioGeneros _servicioGeneros;

        public GenerosController(IMapper mapper,
                                 IServicioGeneros servicioGeneros)
        {
            _mapper = mapper;
            _servicioGeneros = servicioGeneros;
        }

        // GET: Generos
        [HttpGet]
        public async Task<JsonResult> GetAll()
        {
            try
            {
                var generos = await _servicioGeneros.GetAll();
                var map = new GenerosMapper(_mapper);
                var generoVMJson = map.Map(generos);

                //´Los permisos se obtienes de otra tabla.
                //Para esto se requiere implemenetar el módulo de Autorización.

                var acciones = Utils.GetAcciones("generos",null);

                generoVMJson = generoVMJson.Select(g =>
                {
                    g.Acciones = acciones;
                    return g;
                }).ToList();


                return Json(
                        new
                        {
                            datos = generoVMJson,
                            estado = StatusCode((int)HttpStatusCode.OK),
                        });
            }
            catch (Exception ex)
            {
                return Json(
                    new {
                        errors = new List<string> { ex.Message },
                        estado = StatusCode((int)HttpStatusCode.InternalServerError),
                    });
            }
        }

        [HttpGet]
        [Route("{id?}")]
        public async Task<JsonResult> GetByID(int? id)
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

                return Json(
                          new
                          {
                              datos = generoVM,
                              estado = StatusCode((int)HttpStatusCode.OK),
                          });
            }
            catch (Exception ex)
            {
                return Json(
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
        public async Task<JsonResult> Create([FromBody] GeneroRequestDto generoVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var genero = _mapper.Map<Genero>(generoVM);

                    await _servicioGeneros.Create(genero);
                    return Json(
                         new
                         {
                             datos = generoVM,
                             estado = StatusCode((int)HttpStatusCode.OK),
                         });
                }
                else
                    throw new ArgumentException($"Id invalido, StatusCode: {HttpStatusCode.BadRequest}"); 
            }
            catch (Exception ex)
            {
                return Json(
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
        public async Task<JsonResult> Edit(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var genero = _mapper.Map<Genero>(id);

                    if (genero != null)
                    {
                        await _servicioGeneros.Update(genero);
                        return Json(
                             new
                             {
                                 datos = id,
                                 estado = StatusCode((int)HttpStatusCode.OK),
                             });
                    }
                    else
                        return Json(
                        new
                        {
                            errors = new List<string> { $"The id {id} is invalid" },
                            estado = StatusCode((int)HttpStatusCode.BadRequest),
                        });
                }
                else
                    return Json(
                     new
                     {
                         errors = new List<string> { "The model is invalid" },
                         estado = StatusCode((int)HttpStatusCode.InternalServerError),
                     });
            }
            catch (Exception ex)
            {
                return Json(
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
        public async Task<JsonResult> Delete(GeneroRequestDto generoVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var genero = _mapper.Map<Genero>(generoVM);

                    await _servicioGeneros.DeleteConfirmed(genero.Id);
                    return Json(
                         new
                         {
                             datos = generoVM,
                             estado = StatusCode((int)HttpStatusCode.OK),
                         });
                }
                else
                    return Json(
                     new
                     {
                         errors = new List<string> { "The model is invalid" },
                         estado = StatusCode((int)HttpStatusCode.InternalServerError),
                     });
            }
            catch (Exception ex)
            {
                return Json(
                    new
                    {
                        errors = new List<string> { ex.Message },
                        estado = StatusCode((int)HttpStatusCode.InternalServerError),
                    });
            }
        }
    }
}
