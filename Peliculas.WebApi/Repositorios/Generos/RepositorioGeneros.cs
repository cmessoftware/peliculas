using Microsoft.EntityFrameworkCore;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Dto.Genero;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Data.Repositorios
{
    public class RepositorioGeneros : RepositorioGenerico<Genero>, IRepositorioGeneros
    {
        private readonly ILogger _logger;
        private readonly PeliculasContext _context;

        public RepositorioGeneros(ILogger<RepositorioGeneros> logger, PeliculasContext context) : base(logger,
                                                                                     context)
        {
            this._logger = logger;
            this._context = context;
        }

        public new async Task<bool> Create(Genero entity)
        {
            return await base.Create(entity);
        }

        public async Task<bool> Delete(GeneroDeleteDto genero)
        {

            //Verifico si existe ese genero asociado a la pelicula
            var pelicula = await _context.Peliculas.
                                 Include(
                                        p => p.Generos.
                                        Where(g => g.Id == genero.Id).
                                        FirstOrDefault()
                                        ).
                                  Where(x => x.Id == genero.PeliculaId).
                                  FirstOrDefaultAsync();


            if (pelicula != null)
            {
                var gen = pelicula.Generos.FirstOrDefault(x => x.Id == genero.Id);
                //Estoy seguro que existe porque sino pelicula == null.
                _context.Generos.Remove(gen);
                return true;
            }

            return false;
        }


        public async Task<List<Genero>> GetAll(int? peliculaId)
        {
            List<Genero> generos = null;

            if (peliculaId != null)
            {
                var t = Task.Run(() =>
                    {
                        _context.Peliculas.
                                 Include(
                                    p => p.Generos
                                    ).
                                    Where(x => x.Id == peliculaId).
                                    Select(selector: x => x.Generos).
                                    ToList();
                    });

                t.Wait();
            }

            return generos;

        }

        public async Task<Genero> GetById(int? id, int? peliculaId)
        {
            Genero generos = new Genero();


            if (peliculaId != null)
            {
                var t = Task.Run(() =>
                {
                    var generos = _context.Peliculas.
                                        Include(p => p.Generos).
                                        Where(x => x.Id == peliculaId).
                                        Select(selector: x => x.Generos.Where(x => x.Id == id));

                });

                t.Wait();
            }

            return generos;
        }

        public async Task<bool> Update(Genero entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}