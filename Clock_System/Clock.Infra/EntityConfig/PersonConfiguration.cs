using Clock.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clock.Infra.EntityConfig
{
   public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(p => p.IdPerson);
        }
    }
}
