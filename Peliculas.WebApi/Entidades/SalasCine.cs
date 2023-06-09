namespace Peliculas.WebApi.Entidades;

public partial class SalasCine
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Tipo { get; set; }

    public int CineId { get; set; }

    public int UbicacionEnSalaId { get; set; }

    public virtual Cine Cine { get; set; } = null!;

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual ICollection<UbicacionesEnSala> UbicacionesEnSalas { get; set; } = new List<UbicacionesEnSala>();
}
