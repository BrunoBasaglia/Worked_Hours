using Clock.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clock.Infra.EntityConfig
{
   public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.IdAddress);
        }
    }
}
