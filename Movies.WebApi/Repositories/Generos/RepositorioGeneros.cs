using Microsoft.EntityFrameworkCore;
using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Dto.Genero;
using Movies.WebApi.Entities;

namespace Movies.Data.Repositorios
{
    public class RepositorioGeneros : RepositorioGenerico<Gender>, IRepositorioGeneros
    {
        private readonly ILogger _logger;
        private readonly MovieDbContext _context;

        public RepositorioGeneros(ILogger<RepositorioGeneros> logger, MovieDbContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
            this._context = context;
        }

        public new async Task<bool> Create(Gender entity)
        {
            return await base.Create(entity);
        }

        public async Task<bool> Delete(GeneroDeleteDto genero)
        {

            //Verifico si existe ese genero asociado a la pelicula
            var pelicula = await _context.Movies.
                                 Include(
                                        p => p.Genders.
                                        Where(g => g.Id == genero.Id).
                                        FirstOrDefault()
                                        ).
                                  Where(x => x.Id == genero.PeliculaId).
                                  FirstOrDefaultAsync();


            if (pelicula != null)
            {
                var gen = pelicula.Genders.FirstOrDefault(x => x.Id == genero.Id);
                //Estoy seguro que existe porque sino pelicula == null.
                _context.Genders.Remove(gen);
                return true;
            }

            return false;
        }


        public async Task<List<Gender>> GetAll(int? peliculaId)
        {
            List<Gender> generos = null;

            if (peliculaId != null)
            {
                var t = Task.Run(() =>
                    {
                        _context.Movies.
                                 Include(
                                    p => p.Genders
                                    ).
                                    Where(x => x.Id == peliculaId).
                                    Select(selector: x => x.Genders).
                                    ToList();
                    });

                t.Wait();
            }

            return generos;

        }

        public async Task<Gender> GetById(int? id, int? peliculaId)
        {
            Gender generos = new Gender();


            if (peliculaId != null)
            {
                var t = Task.Run(() =>
                {
                    var generos = _context.Movies.
                                        Include(p => p.Genders).
                                        Where(x => x.Id == peliculaId).
                                        Select(selector: x => x.Genders.Where(x => x.Id == id));

                });

                t.Wait();
            }

            return generos;
        }

        public async Task<bool> Update(Gender entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}