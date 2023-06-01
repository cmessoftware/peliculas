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
using Peliculas.Models.Dto;

namespace Peliculas.WebApi.Controllers
{
    [PeliculasActionFilter]
    [ApiController]
    [Route("api/[controller]/[action]")]
   // [Authorize]
    //Agregar /[action] solucion el issue "500 Error when setting up Swagger in asp .net CORE"
    //https://stackoverflow.com/questions/35788911/500-error-when-setting-up-swagger-in-asp-net-core-mvc-6-app
    public class CriticasController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IServicioCriticas _servicioCriticas;
        private readonly ICriticasMapper _criticasMapper;

        public CriticasController(IMapper mapper,
                                  IServicioCriticas servicioCriticas,
                                  ICriticasMapper criticasMapper
                                  )
        {
            _mapper = mapper;
            _servicioCriticas = servicioCriticas;
            _criticasMapper = criticasMapper;
        }

        // GET: Generos
        [HttpGet]
        public async Task<JsonResult> GetAll()
        {
            try
            {
                var criticas = await _servicioCriticas.GetAll();

                var criticasVMJson = _criticasMapper.Map(criticas);

                //´Los permisos se obtienes de otra tabla.
                //Para esto se requiere implemenetar el módulo de Autorización.
                //var user = Indentity.User;
                //TODO: Agregar módulo de indentity.

                var acciones = Utils.GetAcciones("Criticas",null);

                criticasVMJson = criticasVMJson.Select(c =>
                {
                    c.Acciones = acciones;
                    return c;
                }).ToList();


                return Json(
                        new
                        {
                            datos = criticasVMJson,
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

                var Criticas = await _servicioCriticas.GetById(id);

                if (Criticas == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }
                var CriticasVM = _mapper.Map<GeneroDto>(Criticas);

                return Json(
                          new
                          {
                              datos = CriticasVM,
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
        public async Task<JsonResult> Create([FromBody] CriticaRequestDto criticasVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var criticas = _mapper.Map<Critica>(criticasVM);

                    await _servicioCriticas.Create(criticas);
                    return Json(
                         new
                         {
                             datos = criticasVM,
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
                    var critica = _mapper.Map<Critica>(id);

                    if (critica != null)
                    {
                        await _servicioCriticas.Update(critica);
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
        public async Task<JsonResult> Delete(ComentarioRequestDto comentarioVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var comentario = _mapper.Map<Comentario>(comentarioVM);

                    await _servicioCriticas.DeleteConfirmed(comentario.Id);
                    return Json(
                         new
                         {
                             datos = comentarioVM,
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
