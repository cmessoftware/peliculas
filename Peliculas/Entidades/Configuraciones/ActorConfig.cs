using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Peliculas.Entidades.Configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {


            builder.Property(prop => prop.Biografia)
            .HasMaxLength(2000);

            builder.Property(prop => prop.Nombre)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
