using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Peliculas.Data;
using Peliculas.Entidades;

namespace Peliculas.Web.Controllers
{
    public class CinesController : Controller
    {
        private readonly PeliculasDbContext _context;

        public CinesController(PeliculasDbContext context)
        {
            _context = context;
        }

        //// GET: Cines
        //[HttpGet, ActionName("GetCinesByPeliculaId")]
        //[Route("{cines}/{peliculaId:int}")]
        //public async Task<JsonResult> GetCinesByPeliculaId(int id)
        //{
        //    var cine = await _context.Cines.FindAsync(id);
        //    return Json(cine);
            
        //    //return View(await peliculasDbContext.ToListAsync());
        //}
        // GET: Cines
        public async Task<IActionResult> Index()
        {
            var peliculasDbContext = _context.Cines.Include(c => c.Pelicula);
      
            return View(await peliculasDbContext.ToListAsync());
        }

        // GET: Cines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cines == null)
            {
                return NotFound();
            }

            var cine = await _context.Cines
                .Include(c => c.Pelicula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cine == null)
            {
                return NotFound();
            }

            return View(cine);
        }

        // GET: Cines/Create
        public IActionResult Create()
        {
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo");
            return View();
        }

        // POST: Cines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Cadena,Ubicacion,PeliculaId")] Cine cine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", cine.PeliculaId);
            return View(cine);
        }

        // GET: Cines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cines == null)
            {
                return NotFound();
            }

            var cine = await _context.Cines.FindAsync(id);
            if (cine == null)
            {
                return NotFound();
            }
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", cine.PeliculaId);
            return View(cine);
        }

        // POST: Cines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Cadena,Ubicacion,PeliculaId")] Cine cine)
        {
            if (id != cine.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CineExists(cine.Id))
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
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", cine.PeliculaId);
            return View(cine);
        }

        // GET: Cines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cines == null)
            {
                return NotFound();
            }

            var cine = await _context.Cines
                .Include(c => c.Pelicula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cine == null)
            {
                return NotFound();
            }

            return View(cine);
        }

        // POST: Cines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cines == null)
            {
                return Problem("Entity set 'PeliculasDbContext.Cines'  is null.");
            }
            var cine = await _context.Cines.FindAsync(id);
            if (cine != null)
            {
                _context.Cines.Remove(cine);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CineExists(int id)
        {
          return (_context.Cines?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
