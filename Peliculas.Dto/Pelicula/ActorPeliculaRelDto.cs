﻿namespace Peliculas.Dto.DTOs
{
    public class ActorPeliculaRelDto
    {
        public int Id { get; set; }

        public int ActorId { get; set; }

        public int PeliculaId { get; set; }

        public bool EsPrincipal { get; set; }
    }
}