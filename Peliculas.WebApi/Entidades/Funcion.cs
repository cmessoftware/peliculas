namespace Peliculas.WebApi.Entidades;

public partial class Funcion
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int PeliculaId { get; set; }

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual Pelicula Pelicula { get; set; } = null!;
}
