using Clock.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clock.Infra.EntityConfig
{
    public class FrequencyConfiguration : IEntityTypeConfiguration<Frequency>
    {
        public FrequencyConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Frequency> builder)
        {
            builder.HasKey(s => s.IdFrequency);
        }
    }
}
