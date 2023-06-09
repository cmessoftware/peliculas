namespace Peliculas.WebApi.Entidades;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Dni { get; set; }

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();
}
