﻿using AutoMapper;
using Peliculas.Entidades;
using Peliculas.Web.ViewModels;

namespace Peliculas.Mapeos
{
    internal class PeliculasMapperProfile : Profile
    {
        public PeliculasMapperProfile()
        {
            CreateMap<ActorViewModel, Actor>();
            CreateMap<CineViewModel, Cine>();
            CreateMap<ComentarioViewModel, Comentario>();
            CreateMap<CriticaViewModel, Critica>();
            CreateMap<GeneroViewModel, Genero>();
            CreateMap<PeliculaViewModel, Pelicula>();
            CreateMap<SalaViewModel, SalaCine>();

            CreateMap<Actor, ActorViewModel>();
            CreateMap<Cine, CineViewModel>();
            CreateMap<Comentario, ComentarioViewModel>();
            CreateMap<Critica, CriticaViewModel>();
            CreateMap<Genero, GeneroViewModel>();
            CreateMap<Pelicula, PeliculaViewModel>();
            CreateMap<SalaCine, SalaViewModel>();

        }
    }
}