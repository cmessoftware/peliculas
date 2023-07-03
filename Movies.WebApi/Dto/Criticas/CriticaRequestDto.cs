namespace Movies.WebApi.Dto.Criticas
{
    public class CriticaRequestDto
    {
        public int PeliculaId { get; set; }
        public string Contenido { get; set; }
        public string Autor { get; set; }
    }
}