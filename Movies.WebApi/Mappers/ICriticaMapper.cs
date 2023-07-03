using Movies.WebApi.Dto.Criticas;
using Movies.WebApi.Entities;
using Movies.WebApi.Mappers;

namespace Movies.WebApi.Controllers
{
    public interface ICriticaMapper : IGenericMapper<CriticaDto, Critics>
    {
    }
}