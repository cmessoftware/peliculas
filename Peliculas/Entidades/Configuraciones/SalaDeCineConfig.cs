﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Peliculas.Entidades.Configuraciones
{
    public class SalaDeCineConfig : IEntityTypeConfiguration<SalaCine>
    {
        public void Configure(EntityTypeBuilder<SalaCine> builder)
        {
            builder.Property(prop => prop.Precio)
               .HasPrecision(precision: 5, scale: 2);
        }
    }
}
