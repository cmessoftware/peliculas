namespace Peliculas.Entidades
{
    public class Comentario
    {

        public int Id { get; set; }
        public string Contenido { get; set; }

        public string Usuario { get; set; }
        public int MeGustaCantidad { get; set; }
    }
}