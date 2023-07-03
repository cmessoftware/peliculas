namespace Movies.WebApi.Entities
{
    public class Client 
    {
        public int Id { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public List<Address> Addresses { get; set; } = new List<Address>();

        public User User { get; set; }
    }
}
