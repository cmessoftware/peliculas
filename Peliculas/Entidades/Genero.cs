﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Peliculas.Entidades
{
    public class Genero
    {
     
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}