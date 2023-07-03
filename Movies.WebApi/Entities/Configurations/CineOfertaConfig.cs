using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Entities.Configurations
{
    public class CineOfertaConfig : IEntityTypeConfiguration<CinemaOffer>
    {
        public void Configure(EntityTypeBuilder<CinemaOffer> builder)
        {
            builder.Property(prop => prop.Discount)
             .HasPrecision(precision: 2, scale: 2);
        }
    }
}
