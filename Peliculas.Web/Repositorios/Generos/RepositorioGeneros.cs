using Peliculas.Data;
using Peliculas.Entidades;
using Peliculas.Repositorio.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.Web.Repositorios.Generos;

internal class RepositorioGeneros : RepositorioGenerico<Genero>, IRepositorioGeneros
{
    public RepositorioGeneros(PeliculasDbContext context) : base(context)
    {
    }
}