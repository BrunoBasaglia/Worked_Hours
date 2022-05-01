using Clock.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clock.Infra.EntityConfig
{
   public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public StateConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasKey(s => s.IdState);
        }
    }
}
