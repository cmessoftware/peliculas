namespace Peliculas.DTOs
{
    public class SalaDto
    {
        public string Nombre { get; set; }
        public TipoDto Tipo { get; set; }
        public CineDto Cine { get; set; }
    }
}