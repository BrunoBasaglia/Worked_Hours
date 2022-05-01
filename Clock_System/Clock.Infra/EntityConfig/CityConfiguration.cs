using Clock.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clock.Infra.EntityConfig
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.IdCity);
        }
    }
}
