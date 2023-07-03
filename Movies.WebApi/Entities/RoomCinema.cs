namespace Movies.WebApi.Entities;

public partial class RoomCinema
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Type { get; set; }

    public int CineId { get; set; }

    public int RoomCinemaLocationId { get; set; }

    public virtual Cinema Cinema { get; set; } = null!;

    public virtual ICollection<Ticket> Ticket { get; set; } = new List<Ticket>();

    public virtual ICollection<RoomCinemaLocation> RoomCinemaLocations { get; set; } = new List<RoomCinemaLocation>();
}
