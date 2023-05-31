using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Web.Dto;

namespace Peliculas.Mapeos
{
    internal class GenerosMapperProfile : Profile
    {
        public GenerosMapperProfile()
        {

            CreateMap<Genero, GeneroDto>();
            CreateMap<GeneroDto, Genero>();
            CreateMap<GeneroRequestDto, Genero>();
        }
    }
}