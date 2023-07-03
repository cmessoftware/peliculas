using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Entities.Configurations
{
    public class PeliculaConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(prop => prop.Title)
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
