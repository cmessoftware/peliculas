namespace Movies.WebApi.Entities;

public partial class RoomCinemaLocation
{
    public int Id { get; set; }

    public bool Available { get; set; }

    public int Row { get; set; }

    public int Column { get; set; }

    public int RoomCinemaId { get; set; }

    public virtual RoomCinema RoomCinema { get; set; } = null!;
}
