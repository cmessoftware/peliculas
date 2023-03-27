using Peliculas.Data;
using Peliculas.Entidades;
using Peliculas.Repositorio.Peliculas;
using Peliculas.UnitOfWorks;

internal class RepositorioComentarios : RepositorioGenerico<Comentario>, IRepositorioComentarios
{
    public RepositorioComentarios(PeliculasDbContext context) : base(context)
    {
    }
}