namespace Movies.WebApi.Entities;

public partial class Comments
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public Client Client { get; set; } = null!;

    public int Likes { get; set; }

    public int MovieId { get; set; }

    public virtual Movie Movie { get; set; } = null!;
}
