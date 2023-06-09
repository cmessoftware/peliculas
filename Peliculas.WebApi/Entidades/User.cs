namespace Peliculas.WebApi.Entidades;

public partial class User
{
    public int Id { get; set; }

    public int Estado { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public int DireccionId { get; set; }

    public virtual Direccion Direccion { get; set; } = null!;

    public virtual UserLogin? UserLogin { get; set; }
}
