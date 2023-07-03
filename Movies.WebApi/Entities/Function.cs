namespace Movies.WebApi.Entities;

public partial class Function
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime Date { get; set; }

    public int MovieId { get; set; }
    public virtual Movie Movie { get; set; } = null!;
    public virtual ICollection<Ticket> Ticket { get; set; } = new List<Ticket>();

}
