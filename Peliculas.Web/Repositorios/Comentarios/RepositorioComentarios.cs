using Peliculas.Data;
using Peliculas.Entidades;
using Peliculas.Repositorio.Peliculas;
using Peliculas.UnitOfWorks;
using Peliculas.Web.Repositorios.Genero;

internal class RepositorioComentarios : RepositorioGenerico<Comentario>, IRepositorioComentarios
{
    public RepositorioComentarios(PeliculasDbContext context) : base(context)
    {
    }
}