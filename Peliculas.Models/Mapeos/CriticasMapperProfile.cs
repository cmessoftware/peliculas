using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Models.Dto;
using Peliculas.Web.Dto;

namespace Peliculas.Mapeos
{
    internal class CriticasMapperProfile : Profile
    {
        public CriticasMapperProfile()
        {

            CreateMap<Critica, CriticaDto>();
            CreateMap<CriticaDto, Critica>();
            CreateMap<CriticaRequestDto, Critica>();
        }
    }
}