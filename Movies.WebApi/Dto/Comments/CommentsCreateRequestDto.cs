namespace Movies.WebApi.Dto.Comentarios
{
    public record CommentsCreateRequestDto
    {
        public int PeliculaId { get; set; }
        public string Contenido { get; set; }
        public string Usuario { get; set; }
    }
}