namespace Movies.WebApi.Dto.Criticas
{
    public class CriticaDto
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string Autor { get; set; }
        public List<string> Acciones { get; set; }
    }
}