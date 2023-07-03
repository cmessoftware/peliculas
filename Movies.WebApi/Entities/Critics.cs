namespace Movies.WebApi.Entities;

public partial class Critics
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public string Autor { get; set; } = null!;

    public int MovieId { get; set; }

    public virtual Movie Movie { get; set; } = null!;
}
