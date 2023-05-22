using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Peliculas.Entidades;
using Peliculas.Servicios.Peliculas;
using Peliculas.Web.ViewModels;

namespace Peliculas.Web.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly ILogger<PeliculasController> _logger;
        private readonly IMapper _mapper;
        private readonly IServicioPelicula _servicioPelicula;

        public PeliculasController(ILogger<PeliculasController> logger,
                                   IMapper mapper,
                                   IServicioPelicula servicioPelicula)
        {
            _logger = logger;
            _mapper = mapper;
            _servicioPelicula = servicioPelicula;
        }

        // GET: Peliculas
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Entre al Index de PeliculasController");

            return _servicioPelicula != null ?
                    View(await _servicioPelicula.GetAll()) :
                    Problem("Entity set 'PeliculasDbContext.Peliculas'  is null."); ;


        }

       
        // POST: Peliculas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("Id,Titulo,Estreno,PaisOrigen,EnCartelara,Resumen,Director,PosterLink,TrailerLink")] PeliculaViewModel peliculaVM)
        {
            if (ModelState.IsValid)
            {
                //Mapeo
                var pelicula = _mapper.Map<Pelicula>(peliculaVM);

                await _servicioPelicula.Create(pelicula);

                return RedirectToAction(nameof(Index));
            }
            return View(peliculaVM);
        }

        //// GET: Peliculas/Edit/5
        //[HttpGet]
        //[Route("{editar}/{id?}")]
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pelicula = await _servicioPelicula.GetById(id);
        //    if (pelicula == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(pelicula);
        //}

        // POST: Peliculas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Estreno,PaisOrigen,EnCartelara,Resumen,Director,PosterLink,TrailerLink")] PeliculaViewModel peliculaVM)
        {
            if (id != peliculaVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _servicioPelicula.Update(peliculaVM);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await PeliculaExists(peliculaVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(peliculaVM);
        }

        // GET: Peliculas/Delete/5
        //[HttpGet]
        //[Route("{borrar}/{id?}")]
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    if (!await _servicioPelicula.Delete(id))
        //    {
        //        return NotFound();
        //    }

        //    return View("Index");
        //}

        // POST: Peliculas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (id == null)
            {
                return Problem("Entity set 'PeliculasDbContext.Peliculas'  is null.");
            }

            _servicioPelicula.DeleteConfirmed(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> PeliculaExists(int id)
        {
            return await _servicioPelicula.GetById(id) != null;
        }

    }
}
