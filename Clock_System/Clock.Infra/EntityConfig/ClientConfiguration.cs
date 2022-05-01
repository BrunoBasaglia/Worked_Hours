using Clock.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clock.Infra.EntityConfig
{
   public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(s => s.IdClient);
        }
    }
}
