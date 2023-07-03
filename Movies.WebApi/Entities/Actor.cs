namespace Movies.WebApi.Entities;

public partial class Actor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }

    public string? UrlPhoto { get; set; } = null!;

    public int? OriginCountry { get; set; }

    public string? Biography { get; set; } = null!;

    public virtual ICollection<ActorMovie>? ActorMovie { get; set; } = new List<ActorMovie>();
}
