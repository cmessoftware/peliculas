using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Entities.Configurations
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {


            builder.Property(prop => prop.Biography)
            .HasMaxLength(2000);

            builder.Property(prop => prop.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
