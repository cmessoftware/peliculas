using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Peliculas.Web.Entidades;
using System.Reflection.Emit;

namespace Peliculas.Entidades.Configuraciones
{
    public class EntradaConfig : IEntityTypeConfiguration<Entrada>
    {
        public void Configure(EntityTypeBuilder<Entrada> builder)
        {
            builder.Property(prop => prop.Precio)
              .HasPrecision(precision: 5, scale: 2);
        }
    }
}
