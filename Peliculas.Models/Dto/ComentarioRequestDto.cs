namespace Peliculas.Models.Dto
{
    public class ComentarioRequestDto
    {
        public int PeliculaId { get; set; }
        public string Contenido { get; set; }
        public string Usuario { get; set; }
    }
}