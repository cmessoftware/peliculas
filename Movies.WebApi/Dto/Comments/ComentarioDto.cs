namespace Movies.WebApi.Dto
{
    public record ComentarioDto
    {
        public int Id { get; set; }
        public string Contenido { get; set; }
        public string Usuario { get; set; }
        public int MeGustaCantidad { get; set; }
    }
}