using System;
using System.Collections.Generic;

namespace Peliculas.WebApi.Entidades;

public partial class Direccion
{
    public int Id { get; set; }

    public int Pais { get; set; }

    public string Ciudad { get; set; } = null!;

    public string Calle { get; set; } = null!;

    public int Numero { get; set; }

    public string Cp { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
