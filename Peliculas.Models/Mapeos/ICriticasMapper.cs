using Peliculas.Entidades;
using Peliculas.Web.Dto;

namespace Peliculas.WebApi.Controllers
{
    public interface ICriticasMapper
    {
        public List<CriticaDto> Map(List<Critica> critica);
    }
}