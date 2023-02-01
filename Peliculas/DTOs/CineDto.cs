﻿namespace Peliculas.DTOs
{
    public class CineDto
    {
        public string Nombre { get; set; }
        public string Cadena { get; set; }
        public List<PeliculaDto> Peliculas { get; set; }

        public List<SalaDto> Sala { get; set; }

        public DireccionDto Direccion { get; set; }
    }
}