﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Entidades
{
    public class Comentario
    {
      
        public int Id { get; set; }
        public string Contenido { get; set; }

        public string Usuario { get; set; }
        public int MeGustaCantidad { get; set; }

        public int PeliculaId { get; set; }

        public Pelicula Pelicula { get; set; }
    }
}