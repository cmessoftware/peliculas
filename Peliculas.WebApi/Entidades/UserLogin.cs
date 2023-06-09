namespace Peliculas.WebApi.Entidades;

public partial class UserLogin
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public DateTime RegDate { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
