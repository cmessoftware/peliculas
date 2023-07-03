using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Movies.WebApi.Entities.Configurations
{
    public class SalaCineConfig : IEntityTypeConfiguration<RoomCinema>
    {
        public void Configure(EntityTypeBuilder<RoomCinema> builder)
        {

        }
    }
}
