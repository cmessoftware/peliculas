namespace Peliculas.WebApi.Dto.Comentarios
{
    public class ComentarioCreateRequestDto
    {
        public int PeliculaId { get; set; }
        public string Contenido { get; set; }
        public string Usuario { get; set; }
    }
}