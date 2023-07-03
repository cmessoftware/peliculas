using Microsoft.EntityFrameworkCore;
using Movies.Repositorio.Peliculas;
using Movies.UnitOfWorks;
using Movies.WebApi.Data;
using Movies.WebApi.Entities;

public class RepositorioPeliculas : RepositorioGenerico<Movie>, IRepositorioPeliculas
{
    private readonly ILogger _logger;
    private readonly MovieDbContext _context;

    public RepositorioPeliculas(ILogger<RepositorioPeliculas> logger,
                                MovieDbContext context) : base(logger,
                                                                   context)
    {
        this._logger = logger;
        this._context = context;
    }

    public async Task<bool> Create(Movie entity)
    {
        await _context.Movies.AddAsync(entity);
        await _context.SaveChangesAsync();

        return true;

    }

    public async Task<bool> Delete(int? id)
    {

        var peliculas = await _context.Movies
            .Include(c => c.Genders)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (peliculas == null)
        {
            return false;
        }

        return true;
    }

    public async Task<List<Movie>> GetAll()
    {
        return await _context.Movies.Where(x => x.Id > 0).ToListAsync();
    }

    public new async Task<Movie> GetById(int? id)
    {

        var pelicula = await _context.Movies
                             .Include(x => x.Genders)
                             .Include(x => x.Critics)
                             .Include(x => x.Comments)
                              //.Include(x => x.PeliculaActores)
                              //   .ThenInclude(x => x.Actor)
                              // .Include(x => x.Cines)
                              .SingleOrDefaultAsync(x => x.Id == id);




        //var pelicula = await _context.Peliculas.Include(x => x.Generos)
        //                             .Include(x => x.Comentarios)
        //                             .Include(x => x.Criticas)
        //                             .Include(x => x.Cines)
        //                                .ThenInclude(x => x.SalasCine)
        //                             .SingleOrDefaultAsync(x => x.Id == id);



        return pelicula;

    }

    public Task<bool> Update(Movie entity)
    {
        throw new NotImplementedException();
    }
}