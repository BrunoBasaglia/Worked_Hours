using Clock.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clock.Infra.EntityConfig
{
    public class HoursConfiguration : IEntityTypeConfiguration<Hours>
    {
        public HoursConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Hours> builder)
        {
            builder.HasKey(h => h.IdHour);
        }
    }
}
