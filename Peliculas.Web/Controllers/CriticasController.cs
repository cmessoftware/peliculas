using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Peliculas.Data;
using Peliculas.Entidades;

namespace Peliculas.Web.Controllers
{
    public class CriticasController : Controller
    {
        private readonly PeliculasDbContext _context;

        public CriticasController(PeliculasDbContext context)
        {
            _context = context;
        }

        // GET: Criticas
        public async Task<IActionResult> Index()
        {
            var peliculasDbContext = _context.Criticas.Include(c => c.Pelicula);
            return View(await peliculasDbContext.ToListAsync());
        }

        // GET: Criticas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Criticas == null)
            {
                return NotFound();
            }

            var critica = await _context.Criticas
                .Include(c => c.Pelicula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (critica == null)
            {
                return NotFound();
            }

            return View(critica);
        }

        // GET: Criticas/Create
        public IActionResult Create()
        {
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo");
            return View();
        }

        // POST: Criticas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Contenido,Autor,PeliculaId")] Critica critica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(critica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", critica.PeliculaId);
            return View(critica);
        }

        // GET: Criticas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Criticas == null)
            {
                return NotFound();
            }

            var critica = await _context.Criticas.FindAsync(id);
            if (critica == null)
            {
                return NotFound();
            }
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", critica.PeliculaId);
            return View(critica);
        }

        // POST: Criticas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Contenido,Autor,PeliculaId")] Critica critica)
        {
            if (id != critica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(critica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CriticaExists(critica.Id))
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
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "Id", "Titulo", critica.PeliculaId);
            return View(critica);
        }

        // GET: Criticas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Criticas == null)
            {
                return NotFound();
            }

            var critica = await _context.Criticas
                .Include(c => c.Pelicula)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (critica == null)
            {
                return NotFound();
            }

            return View(critica);
        }

        // POST: Criticas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Criticas == null)
            {
                return Problem("Entity set 'PeliculasDbContext.Criticas'  is null.");
            }
            var critica = await _context.Criticas.FindAsync(id);
            if (critica != null)
            {
                _context.Criticas.Remove(critica);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CriticaExists(int id)
        {
          return (_context.Criticas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
