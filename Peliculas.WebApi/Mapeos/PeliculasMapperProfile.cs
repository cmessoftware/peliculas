using AutoMapper;
using Peliculas.WebApi.Entidades;
using Peliculas.Web.Dto;
using Peliculas.WebApi.Dto;
using Peliculas.WebApi.Dto.Comentarios;

namespace Peliculas.Mapeos
{
    internal class PeliculasMapperProfile : Profile
    {
        public PeliculasMapperProfile()
        {
            //Comentarios Mapper
            CreateMap<Comentario, ComentarioDto>();
            CreateMap<ComentarioDto, Comentario>();
            CreateMap<ComentarioCreateRequestDto, Comentario>();

            //Criticas Mapper
            CreateMap<Critica, CriticaDto>();
            CreateMap<CriticaDto, Critica>();
            CreateMap<CriticaRequestDto, Critica>();

            //Genero Mapper
            CreateMap<Genero, GeneroDto>();
            CreateMap<GeneroDto, Genero>();
            CreateMap<GeneroRequestDto, Genero>();

            //UserLogin Mapper
            CreateMap<UserLogin, UserLoginDto>();
            CreateMap<UserLoginDto, UserLogin>();



            CreateMap<ActorDto, Actor>();
            CreateMap<CineDto, Cine>();
            CreateMap<CriticaDto, Critica>();
            CreateMap<GeneroDto, Genero>();
            CreateMap<PeliculaDto, Pelicula>();
            CreateMap<SalaDto, SalasCine>();

            CreateMap<Actor, ActorDto>();
            CreateMap<Cine, CineDto>();
            CreateMap<Critica, CriticaDto>();
            CreateMap<Genero, GeneroDto>();
            CreateMap<Pelicula, PeliculaDto>();
            CreateMap<SalasCine, SalaDto>();

          
        }
    }
}