using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Web.Dto;

namespace Peliculas.Mapeos
{
    internal class PeliculasMapperProfile : Profile
    {
        public PeliculasMapperProfile()
        {
            CreateMap<ActorDto, Actor>();
            CreateMap<CineDto, Cine>();
            CreateMap<ComentarioDto, Comentario>();
            CreateMap<CriticaDto, Critica>();
            CreateMap<GeneroDto, Genero>();
            CreateMap<PeliculaDto, Pelicula>();
            CreateMap<SalaDto, SalaCine>();

            CreateMap<Actor, ActorDto>();
            CreateMap<Cine, CineDto>();
            CreateMap<Comentario, ComentarioDto>();
            CreateMap<Critica, CriticaDto>();
            CreateMap<Genero, GeneroDto>();
            CreateMap<Pelicula, PeliculaDto>();
            CreateMap<SalaCine, SalaDto>();

        }
    }
}