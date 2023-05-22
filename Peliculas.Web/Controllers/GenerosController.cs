using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Peliculas.Entidades;
using Peliculas.Servicios;
using Peliculas.Web.Filters;
using Peliculas.Web.Mapeos;
using Peliculas.Web.ViewModels;

namespace Peliculas.Web.Controllers
{
    [PeliculasActionFilter]
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

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Generos/List
        [HttpGet]
        [Route("{generos}/{list}")]
        public async Task<IActionResult> GetGeneros()
        {
            var generos = await _servicioGeneros.GetAll();

            var map = new GenerosMapper(_mapper);
            var generosVM = map.Map(generos);

            return View("Index",generosVM);
        }

        [HttpGet]
        [Route("{generos}/{list}/{id?}")]
        public async Task<IActionResult> GetByID(int? id)
        {
            if (id == null)
            {
                return BadRequest($"id {id} is invalid");
            }

            var genero = await _servicioGeneros.GetById(id);

            if (genero == null)
            {
                return BadRequest($"id {id} is invalid");
            }
            var generoVM = _mapper.Map<GeneroViewModel>(genero);

            return View(generoVM);
        }



        // POST: Generos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] GeneroViewModel generoVM)
        {
            if (ModelState.IsValid)
            {
                var genero = _mapper.Map<Genero>(generoVM);
                await _servicioGeneros.Create(genero);

                return View(generoVM);
            }
            else
                return BadRequest($"id {generoVM.Id} is invalid");


        }

        // GET: Generos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest($"id {id} is invalid");
            }

            var genero = await _servicioGeneros.GetById(id);
            if (genero == null)
            {
                return BadRequest($"id {id} is invalid");
            }

            var generoVM = _mapper.Map<GeneroViewModel>(genero);

            return View(generoVM);
        }

        // POST: Generos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] GeneroViewModel generoVM)
        {
            if (id != generoVM.Id)
            {
                return BadRequest($"id {id} is invalid");
            }
     
            if (ModelState.IsValid)
            {
                try
                {
                    var genero = _mapper.Map<Genero>(generoVM);
                    await _servicioGeneros.Update(genero);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneroExists(generoVM.Id))
                    {
                        return BadRequest($"id {id} is invalid");
                    }
                    else
                    {
                        throw;
                    }
                }
                generoVM = _mapper.Map<GeneroViewModel>(generoVM);

                return View(generoVM);
            }
            else
                return BadRequest($"id {id} is invalid");

        }

        // GET: Generos/Delete/5
        [HttpDelete]
        [Route("{generos}/{delete}/{id?}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genero = await _servicioGeneros.GetById(id);

            if (genero == null)
            {
                return NotFound();
            }

            return genero != null ? Json(genero) : NotFound();
        }


        // POST: Generos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("{generos}/{delete}")]
        public async Task<IActionResult> DeleteConfirmed([FromBody] GeneroViewModel genero)
        {

            if (genero == null)
                return Problem("Entity set 'PeliculasDbContext.Generos'  is null.");

            if (!await _servicioGeneros.DeleteConfirmed(genero.Id))
                return Problem($"DeleteConfirmed id {genero.Id} was failed!!");

            return Json(genero);
        }

        private bool GeneroExists(int id)
        {
            return _servicioGeneros.GetById(id) != null;
        }
    }
}
