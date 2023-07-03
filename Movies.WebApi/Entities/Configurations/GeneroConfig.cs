using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.WebApi.Entities;

namespace Movies.WebApi.Entities.Configurations
{
    public class GeneroConfig : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.Property(prop => prop.Name)
               .HasMaxLength(100)
               .IsRequired();
        }
    }
}
