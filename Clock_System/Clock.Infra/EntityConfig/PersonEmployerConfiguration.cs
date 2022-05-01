using Clock.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clock.Infra.EntityConfig
{
    public class PersonEmployerConfiguration : IEntityTypeConfiguration<PersonEmployer>
    {
        public PersonEmployerConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<PersonEmployer> builder)
        {
            builder.HasKey(p => p.IdPerson);
            builder.HasKey(pe => new { pe.IdPerson, pe.IdEmployer });
        }
    }
}
