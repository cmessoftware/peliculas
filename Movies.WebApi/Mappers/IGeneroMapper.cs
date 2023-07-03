using Movies.WebApi.Dto.Genero;
using Movies.WebApi.Entities;
using Movies.WebApi.Mappers;

namespace Movies.Web.Mapeos
{
    public interface IGeneroMapper : IGenericMapper<GeneroDto, Gender>
    {

    }
}