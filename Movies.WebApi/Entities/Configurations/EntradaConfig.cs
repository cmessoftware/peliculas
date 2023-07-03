using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Entities.Configurations
{
    public class EntradaConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.Property(prop => prop.Price)
              .HasPrecision(precision: 5, scale: 2);
        }
    }
}
