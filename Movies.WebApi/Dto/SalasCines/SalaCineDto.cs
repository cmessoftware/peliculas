using Movies.WebApi.Dto.Cines;
using Movies.WebApi.Dto.TipoSalaCines;

namespace Movies.WebApi.Dto.SalasCines
{
    public class SalaCineDto
    {
        public string Nombre { get; set; }
        public TipoSalaCineDto Tipo { get; set; }
        public CinemaDto Cine { get; set; }
    }
}