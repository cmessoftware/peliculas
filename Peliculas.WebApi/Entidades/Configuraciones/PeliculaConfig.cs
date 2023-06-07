using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Entidades.Configuraciones
{
    public class PeliculaConfig : IEntityTypeConfiguration<Pelicula>
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            builder.Property(prop => prop.Titulo)
                        .HasMaxLength(250)
                        .IsRequired();

            builder.Property(prop => prop.PosterLink)
                .HasMaxLength(500)
                .IsUnicode(false);

            builder.Property(prop => prop.TrailerLink)
               .HasMaxLength(500)
               .IsUnicode(false);

        }
    }
}
