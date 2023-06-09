﻿namespace Peliculas.WebApi.Entidades;

public partial class CineOferta
{
    public int Id { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public decimal PorcentajeDescuento { get; set; }

    public int CineId { get; set; }

    public virtual Cine Cine { get; set; } = null!;
}
