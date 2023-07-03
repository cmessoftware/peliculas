namespace Movies.WebApi.Dto.Genero
{
    public record GeneroDeleteDto
    {
        public int Id { get; set; }
        public int PeliculaId { get; set; }
    }
}