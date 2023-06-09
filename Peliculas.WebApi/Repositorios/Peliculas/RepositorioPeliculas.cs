﻿using Microsoft.EntityFrameworkCore;
using Peliculas.Repositorio.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.WebApi.Entidades;

public class RepositorioPeliculas : RepositorioGenerico<Pelicula>, IRepositorioPeliculas
{
    private readonly ILogger _logger;
    private readonly PeliculasContext _context;

    public RepositorioPeliculas(ILogger<RepositorioPeliculas> logger,
                                PeliculasContext context) : base(logger,
                                                                   context)
    {
        this._logger = logger;
        this._context = context;
    }

    public async Task<bool> Create(Pelicula entity)
    {
        await _context.Peliculas.AddAsync(entity);
        await _context.SaveChangesAsync();

        return true;

    }

    public async Task<bool> Delete(int? id)
    {

        var peliculas = await _context.Peliculas
            .Include(c => c.Generos)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (peliculas == null)
        {
            return false;
        }

        return true;
    }

    public async Task<List<Pelicula>> GetAll()
    {
        return await _context.Peliculas.Where(x => x.Id > 0).ToListAsync();
    }

    public new async Task<Pelicula> GetById(int? id)
    {

        var pelicula = await _context.Peliculas
                             .Include(x => x.Generos)
                             .Include(x => x.Criticas)
                             .Include(x => x.Comentarios)
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

    public Task<bool> Update(Pelicula entity)
    {
        throw new NotImplementedException();
    }
}