using System;
using System.Collections.Generic;

namespace Peliculas.WebApi.Entidades;

public partial class Pelicula
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public int Estreno { get; set; }

    public int PaisOrigen { get; set; }

    public bool EnCartelera { get; set; }

    public string Resumen { get; set; } = null!;

    public string Director { get; set; } = null!;

    public string PosterLink { get; set; } = null!;

    public string TrailerLink { get; set; } = null!;

    public virtual ICollection<Cine> Cines { get; set; } = new List<Cine>();

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual ICollection<Critica> Criticas { get; set; } = new List<Critica>();

    public virtual ICollection<Funcion> Funciones { get; set; } = new List<Funcion>();

    public virtual ICollection<Actor> Actores { get; set; } = new List<Actor>();

    public virtual ICollection<Genero> Generos { get; set; } = new List<Genero>();
}
