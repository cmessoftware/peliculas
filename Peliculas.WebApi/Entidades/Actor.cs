using System;
using System.Collections.Generic;

namespace Peliculas.WebApi.Entidades;

public partial class Actor
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Edad { get; set; }

    public string FotoUrl { get; set; } = null!;

    public int PaisOrigen { get; set; }

    public string Biografia { get; set; } = null!;

    public virtual ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
}
