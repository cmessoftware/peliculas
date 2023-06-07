using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Peliculas.WebApi.Entidades;

namespace Peliculas.Entidades.Configuraciones
{
    public class SalaCineConfig : IEntityTypeConfiguration<SalasCine>
    {
        public void Configure(EntityTypeBuilder<SalasCine> builder)
        {

        }
    }
}
