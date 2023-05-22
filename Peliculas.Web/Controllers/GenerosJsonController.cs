using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Peliculas.Common.Utils;
using Peliculas.Entidades;
using Peliculas.Servicios;
using Peliculas.Web.Filters;
using Peliculas.Web.Mapeos;
using Peliculas.Web.ViewModels;
using System.Linq;

namespace Peliculas.Web.Controllers
{
    [PeliculasActionFilter]
    [Route("api/[controller]")]
    public class GenerosJsonController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IServicioGeneros _servicioGeneros;

        public GenerosJsonController(IMapper mapper,
                                     IServicioGeneros servicioGeneros)
        {
            _mapper = mapper;
            _servicioGeneros = servicioGeneros;
        }

        // GET: Generos
        [HttpGet()]
        public async Task<JsonResult> Index()
        {
            try
            {
                var generos = await _servicioGeneros.GetAll();
                var map = new GenerosMapper(_mapper);
                var generoVMJson = map.MapJson(generos);

                //´Los permisos se obtienes de otra tabla.
                //Para esto se requiere implemenetar el módulo de Autorización.

                var acciones = Utils.GetAcciones("generos");

                generoVMJson = generoVMJson.Select(g =>
                {
                    g.Acciones = acciones;
                    return g;
                }).ToList();


                return Json(
                        new
                        {
                            datos = generoVMJson,
                            estado = true
                        });
            }
            catch (Exception ex)
            {
                return Json(
                    new {
                        errors = new List<string> { ex.Message },
                        estado = false,
                    });
            }
        }

        [HttpGet]
        [Route("{generos}/{id?}")]
        public async Task<string> GetByID(int? id)
        {
            if (id == null)
            {
                return $"id {id} is invalid";
            }

            var genero = await _servicioGeneros.GetById(id);

            if (genero == null)
            {
                return $"id {id} is invalid";
            }
            var generoVM = _mapper.Map<GeneroViewModel>(genero);

            return JsonConvert.SerializeObject(generoVM);
        }



        // POST: Generos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<string> Create([Bind("Id,Nombre")] GeneroViewModel generoVM)
        {
            if (ModelState.IsValid)
            {
                var genero = _mapper.Map<Genero>(generoVM);

                await _servicioGeneros.Create(genero);
                return JsonConvert.SerializeObject(generoVM);
            }
            else
                return "The model is invalid.";

         
        }

        // GET: Generos/Edit/5
        public async Task<string> Edit(int? id)
        {
            if (id == null)
            {
                return $"id {id} is invalid";
            }

            var genero = await _servicioGeneros.GetById(id);
            if (genero == null)
            {
                return $"id {id} is invalid";
            }

            var generoVM = _mapper.Map<GeneroViewModel>(genero);

            return JsonConvert.SerializeObject(generoVM);
        }
    }
}
