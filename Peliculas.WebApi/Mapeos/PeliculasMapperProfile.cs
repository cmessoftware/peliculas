using AutoMapper;
using Peliculas.Web.Dto;
using Peliculas.WebApi.Dto;
using Peliculas.WebApi.Dto.Actores;
using Peliculas.WebApi.Dto.Comentarios;
using Peliculas.WebApi.Dto.Genero;
using Peliculas.WebApi.Entidades;

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
            CreateMap<GeneroCreateDto, Genero>();

            //UserLogin Mapper
            CreateMap<UserLogin, UserLoginDto>();
            CreateMap<UserLoginDto, UserLogin>();


            //Actor Mapper
            CreateMap<ActorDto, Actor>();
            CreateMap<Actor, ActorDto>();
            CreateMap<ActorCreateRequestDto, Actor>();

            //Cine Mapper
            CreateMap<CineDto, Cine>();
            CreateMap<Cine, CineDto>();

            //Critica Mapper
            CreateMap<CriticaDto, Critica>();
            CreateMap<Critica, CriticaDto>();

            //Genero Mapper
            CreateMap<GeneroDto, Genero>();
            CreateMap<Genero, GeneroDto>();

            //Pelicula Mapper
            CreateMap<PeliculaDto, Pelicula>();
            CreateMap<Pelicula, PeliculaDto>();

            //Sala Mapper
            CreateMap<SalaCineDto, SalasCine>();
            CreateMap<SalasCine, SalaCineDto>();
        }
    }
}