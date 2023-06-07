using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Peliculas.WebApi.Entidades;

public partial class Cine
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Cadena { get; set; } = null!;

    public Geometry Ubicacion { get; set; } = null!;

    public int PeliculaId { get; set; }

    public virtual ICollection<CineOferta> CineOferta { get; set; } = new List<CineOferta>();

    public virtual Pelicula Pelicula { get; set; } = null!;

    public virtual ICollection<SalasCine> SalasCines { get; set; } = new List<SalasCine>();
}
