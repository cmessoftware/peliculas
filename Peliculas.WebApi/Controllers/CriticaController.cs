using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Peliculas.Common.Utils;
using Peliculas.WebApi.Entidades;
using Peliculas.Servicios;
using Peliculas.Web.Dto;
using Peliculas.Web.Filters;
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
    public class CriticaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IServicioCriticas _servicioCriticas;
        private readonly IGenericMapper<CriticaDto, Critica> _criticasMapper;

        public CriticaController(IMapper mapper,
                                  IServicioCriticas servicioCriticas,
                                  IGenericMapper<CriticaDto, Critica> criticasMapper
                                  )
        {
            _mapper = mapper;
            _servicioCriticas = servicioCriticas;
            _criticasMapper = criticasMapper;
        }

        // GET: Generos
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var criticas = await _servicioCriticas.GetAll();

                var criticasVMJson = _criticasMapper.Map(criticas);

                //´Los permisos se obtienes de otra tabla.
                //Para esto se requiere implemenetar el módulo de Autorización.
                //var user = Indentity.User;
                //TODO: Agregar módulo de indentity.

                var acciones = Utils.GetAcciones("Criticas", null);

                criticasVMJson = criticasVMJson.Select(c =>
                {
                    c.Acciones = acciones;
                    return c;
                }).ToList();


                return Ok(
                        new
                        {
                            datos = criticasVMJson,
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

                var Criticas = await _servicioCriticas.GetById(id);

                if (Criticas == null)
                {
                    throw new ArgumentException($"id {id} is invalid");
                }
                var CriticasVM = _mapper.Map<GeneroDto>(Criticas);

                return Ok(
                          new
                          {
                              datos = CriticasVM,
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

        public async Task<IActionResult> Create([FromBody] CriticaRequestDto criticasVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var criticas = _mapper.Map<Critica>(criticasVM);

                    await _servicioCriticas.Create(criticas);
                    return Ok(
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
        [Route("edit")]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var critica = _mapper.Map<Critica>(id);

                    if (critica != null)
                    {
                        await _servicioCriticas.Update(critica);
                        return BadRequest(
                             new
                             {
                                 datos = id,
                                 estado = StatusCode((int)HttpStatusCode.OK),
                             });
                    }
                    else
                        return BadRequest(
                        new
                        {
                            errors = new List<string> { $"The id {id} is invalid" },
                            estado = StatusCode((int)HttpStatusCode.BadRequest),
                        });
                }
                else
                    return Ok(
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

                    await _servicioCriticas.Delete(id);
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
