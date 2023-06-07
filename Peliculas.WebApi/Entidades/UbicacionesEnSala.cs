namespace Peliculas.WebApi.Entidades;

public partial class UbicacionesEnSala
{
    public int Id { get; set; }

    public bool Disponible { get; set; }

    public int Fila { get; set; }

    public int Columna { get; set; }

    public int SalaCineId { get; set; }

    public virtual SalasCine SalaCine { get; set; } = null!;
}
