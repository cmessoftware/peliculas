using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Movies.WebApi.Dto;
using Movies.WebApi.Dto.Account;
using Movies.WebApi.Dto.Actores;
using Movies.WebApi.Dto.Cines;
using Movies.WebApi.Dto.Comentarios;
using Movies.WebApi.Dto.Criticas;
using Movies.WebApi.Dto.Genero;
using Movies.WebApi.Dto.SalasCines;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Mappers
{
    internal class MovieMapperProfile : Profile
    {
        public MovieMapperProfile()
        {
            //Comentarios Mapper
            CreateMap<Comments, ComentarioDto>();
            CreateMap<ComentarioDto, Comments>();
            CreateMap<CommentsCreateRequestDto, Comments>();

            //Criticas Mapper
            CreateMap<Critics, CriticaDto>();
            CreateMap<CriticaDto, Critics>();
            CreateMap<CriticaRequestDto, Critics>();

            //Genero Mapper
            CreateMap<Gender, GeneroDto>();
            CreateMap<GeneroDto, Gender>();
            CreateMap<GeneroCreateDto, Gender>();

         
            //Actor Mapper
            CreateMap<ActorDto, Actor>();
            CreateMap<Actor, ActorDto>();
            CreateMap<ActorCreateRequestDto, Actor>();

            //Cine Mapper
            CreateMap<CinemaDto, Cinema>();
            CreateMap<Cinema, CinemaDto>();

            //Critica Mapper
            CreateMap<CriticaDto, Critics>();
            CreateMap<Critics, CriticaDto>();

            //Genero Mapper
            CreateMap<GeneroDto, Gender>();
            CreateMap<Gender, GeneroDto>();

            //Pelicula Mapper
            CreateMap<MoviesDto, Movie>();
            CreateMap<Movie, MoviesDto>();

            //Sala Mapper
            CreateMap<SalaCineDto, RoomCinema>();
            CreateMap<RoomCinema, SalaCineDto>();

            //Address Mapper
            CreateMap<AddressDto, Address>();
            CreateMap<Address, AddressDto>();

            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();

            CreateMap<RoleDto, Role>();
            CreateMap<Role, RoleDto>();

        }
    }
}