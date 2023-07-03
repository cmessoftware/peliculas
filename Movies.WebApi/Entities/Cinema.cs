using NetTopologySuite.Geometries;

namespace Movies.WebApi.Entities;

public partial class Cinema
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Chain { get; set; } = null!;

    public Geometry Location { get; set; } = null!;

    public int MovieId { get; set; }

    public virtual Movie Movie { get; set; } = null!;

    public virtual ICollection<CinemaOffer> CinemaOffer { get; set; } = new List<CinemaOffer>();
  
    public virtual ICollection<RoomCinema> CinemaRoom { get; set; } = new List<RoomCinema>();
}
