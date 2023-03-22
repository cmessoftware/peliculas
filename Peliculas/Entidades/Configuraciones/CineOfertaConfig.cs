﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Peliculas.Entidades.Configuraciones
{
    public class CineOfertaConfig : IEntityTypeConfiguration<CineOferta>
    {
        public void Configure(EntityTypeBuilder<CineOferta> builder)
        {
            builder.Property(prop => prop.PorcentajeDescuento)
             .HasPrecision(precision: 2, scale: 2);
        }
    }
}
