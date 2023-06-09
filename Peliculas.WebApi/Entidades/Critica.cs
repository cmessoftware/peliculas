namespace Peliculas.WebApi.Entidades;

public partial class Critica
{
    public int Id { get; set; }

    public string Contenido { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public int PeliculaId { get; set; }

    public virtual Pelicula Pelicula { get; set; } = null!;
}
