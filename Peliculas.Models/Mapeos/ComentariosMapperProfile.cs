using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Models.Dto;
using Peliculas.Web.Dto;

namespace Peliculas.Mapeos
{
    internal class ComentariosMapperProfile : Profile
    {
        public ComentariosMapperProfile()
        {

            CreateMap<Comentario, ComentarioDto>();
            CreateMap<ComentarioDto, Comentario>();
            CreateMap<ComentarioRequestDto, Comentario>();
        }
    }
}