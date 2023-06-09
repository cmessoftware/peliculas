namespace Peliculas.Web.Dto
{
    public class SalaCineDto
    {
        public string Nombre { get; set; }
        public TipoDto Tipo { get; set; }
        public CineDto Cine { get; set; }
    }
}