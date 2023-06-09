using Peliculas.Web.Dto;
using Peliculas.WebApi.Entidades;
using Peliculas.WebApi.Mapeos;

namespace Peliculas.WebApi.Controllers
{
    public interface ICriticaMapper : IGenericMapper<CriticaDto, Critica>
    {
    }
}