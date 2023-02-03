namespace Peliculas.DTOs
{
    public class ComentarioDto
    {
        public int Id { get; set; }
        public string Contenido { get; set; }

        public string Usuario { get; set; } //Tomar de clase usuario.

        public int MeGustaCantidad { get; set; }
    }
}