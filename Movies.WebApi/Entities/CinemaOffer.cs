namespace Movies.WebApi.Entities
{
    public partial class CinemaOffer
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Discount { get; set; }

        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; } = null!;
    }
}