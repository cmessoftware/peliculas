﻿using AutoMapper;

using Microsoft.SqlServer.Server;

using Peliculas.DTOs;
using Peliculas.Entidades;

namespace Peliculas.Mapeos
{
    internal class PeliculasMapperProfile:Profile
    {
        public PeliculasMapperProfile ()
        {
            CreateMap<ActorDto, Actor> ();
            CreateMap<ActorPeliculaRelDto, PeliculaActor> ();
            CreateMap<CineDto, Cine> ();
            CreateMap<ComentarioDto, Comentario> ();
            CreateMap<CriticaDto, Critica> ();
            CreateMap<DireccionDto, Direccion> ();
            CreateMap<GeneroDto, Genero> ();
            CreateMap<PeliculaDto, Pelicula> ();
            CreateMap<SalaDto, SalaCine> ();

            CreateMap<Actor, ActorDto>();
            CreateMap<PeliculaActor, ActorPeliculaRelDto>();
            CreateMap<Cine, CineDto>();
            CreateMap<Comentario, ComentarioDto>();
            CreateMap<Critica, CriticaDto>();
            CreateMap<Direccion, DireccionDto>();
            CreateMap<Genero, GeneroDto>();
            CreateMap<Pelicula, PeliculaDto>();
            CreateMap<SalaCine, SalaDto>();
        }
    }
}