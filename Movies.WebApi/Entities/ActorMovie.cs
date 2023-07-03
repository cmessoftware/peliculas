namespace Movies.WebApi.Entities
{
    public class ActorMovie
    {
        public int Id { get; set; }
        public int ActordId { get; set; }
        public int MoviesId { get; set; } 
        public bool IsLeadActor { get; set; }

        public string Character { get; set; }

    }
}