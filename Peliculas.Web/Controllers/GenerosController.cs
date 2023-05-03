using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Peliculas.Data;
using Peliculas.Entidades;
using Peliculas.Web.ViewModels;

namespace Peliculas.Web.Controllers
{
    public class GenerosController : Controller
    {
        private readonly IMapper _mapper;
        private readonly PeliculasDbContext _context;

        public GenerosController(IMapper mapper ,
                                 PeliculasDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        // GET: Generos
        public async Task<IActionResult> Index()
        {

            if(_context.Generos == null)
                return NotFound();
                        
            
            var generos = await _context.Generos.ToListAsync();

            var generosSelectList = new List<SelectListItem>();
            var generosVM = new GeneroViewModel();

            foreach (var gen in generos)
            {
                generosSelectList.Add(new SelectListItem()
                {
                    Text = gen.Nombre,
                    Value = gen.Id.ToString()
                }); 
            }

            generosVM.Generos ??= new List<SelectListItem>(); 
            generosVM.Generos.AddRange(generosSelectList);


            return View(generosVM);

            #region Ejemplo
            //var model = new GeneroViewModel()
            //{
            //    Generos = new List<SelectListItem>()
            //    {
            //        new SelectListItem()
            //        {
            //            Text = "Genero 1",
            //            Value = "1"
            //        },
            //         new SelectListItem()
            //        {
            //            Text = "Genero 2",
            //            Value = "2"
            //        },
            //          new SelectListItem()
            //        {
            //            Text = "Genero 3",
            //            Value = "3"
            //        },
            //           new SelectListItem()
            //        {
            //            Text = "Genero 4",
            //            Value = "4"
            //        },
            //            new SelectListItem()
            //        {
            //            Text = "Genero 5",
            //            Value = "5"
            //        }
            //    },
            //    Nombre = "Generos de Pelicula"
            //};

            //return View(model);
            #endregion
        }

        // GET: Generos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Generos == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (genero == null)
            {
                return NotFound();
            }

            return View(genero);
        }

        // GET: Generos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Generos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Genero genero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(genero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(genero);
        }

        // GET: Generos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Generos == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos.FindAsync(id);
            if (genero == null)
            {
                return NotFound();
            }
            return View(genero);
        }

        // POST: Generos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Genero genero)
        {
            if (id != genero.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(genero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneroExists(genero.Id))
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
            return View(genero);
        }

        // GET: Generos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Generos == null)
            {
                return NotFound();
            }

            var genero = await _context.Generos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (genero == null)
            {
                return NotFound();
            }

            return View(genero);
        }

        // POST: Generos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Generos == null)
            {
                return Problem("Entity set 'PeliculasDbContext.Generos'  is null.");
            }
            var genero = await _context.Generos.FindAsync(id);
            if (genero != null)
            {
                _context.Generos.Remove(genero);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneroExists(int id)
        {
          return (_context.Generos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
