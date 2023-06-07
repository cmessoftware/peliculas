using System;
using System.Collections.Generic;

namespace Peliculas.WebApi.Entidades;

public partial class Entrada
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public int? FuncionId { get; set; }

    public int? ClienteId { get; set; }

    public byte[] QrcodeImage { get; set; } = null!;

    public int? SalaCineId { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Funcion? Funcion { get; set; }

    public virtual SalasCine? SalaCine { get; set; }
}
