namespace Movies.WebApi.Entities;

public partial class Ticket
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int? FunctionId { get; set; }

    public int? ClientId { get; set; }

    public byte[] QrcodeImage { get; set; } = null!;

    public int? RoomCinemaId { get; set; }

    public virtual Client? Client { get; set; }

    public virtual Function? Function { get; set; }

    public virtual RoomCinema? RoomCinema { get; set; }
}
