namespace Peliculas.WebApi.Entidades;

public partial class Comentario
{
    public int Id { get; set; }

    public string Contenido { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public int MeGustaCantidad { get; set; }

    public int PeliculaId { get; set; }

    public virtual Pelicula Pelicula { get; set; } = null!;
}
