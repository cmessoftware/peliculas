using Peliculas.Data;
using Peliculas.Entidades;
using Peliculas.Repositorio.Peliculas;
using Peliculas.UnitOfWorks;

internal class RepositorioPeliculas : RepositorioGenerico<Pelicula>, IRepositorioPeliculas
{
    public RepositorioPeliculas(PeliculasDbContext context) : base(context)
    {
    }

    public new async Task<Pelicula> GetById(int id)
    {
        var pelicula = (await GetAll())
                       .FirstOrDefault(x => x.Id == id);

        return pelicula;
    }
}