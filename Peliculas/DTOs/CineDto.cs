namespace Peliculas.DTOs
{
    public class CineDto
    {
        public string Nombre { get; set; }
        public string Cadena { get; set; }
        public List<SalaDto> Salas { get; set; }
        public DireccionDto Direccion { get; set; }
        public string LogoCine { get; set; }
    }
}