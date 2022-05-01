using Clock.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clock.Infra.EntityConfig
{
    public class EmployerConfiguration : IEntityTypeConfiguration<Employer>
    {
        public EmployerConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasKey(e => e.IdEmployer);
        }
    }
}
