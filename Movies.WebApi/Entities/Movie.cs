namespace Movies.WebApi.Entities;

public partial class Movie
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int ReleaseDate { get; set; }

    public int OriginCountry { get; set; }

    public bool InBillboard { get; set; }

    public string Summary { get; set; } = null!;

    public string Director { get; set; } = null!;

    public string PosterLink { get; set; } = null!;

    public string TrailerLink { get; set; } = null!;

    public virtual ICollection<Cinema> Cinemas { get; set; } = new List<Cinema>();

    public virtual ICollection<Comments> Comments { get; set; } = new List<Comments>();

    public virtual ICollection<Critics> Critics { get; set; } = new List<Critics>();

    public virtual ICollection<Function> Functions { get; set; } = new List<Function>();

    public virtual ICollection<ActorMovie> ActorMovie { get; set; } = new List<ActorMovie>();

    public virtual ICollection<Gender> Genders { get; set; } = new List<Gender>();
}
