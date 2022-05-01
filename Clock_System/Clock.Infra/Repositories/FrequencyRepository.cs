using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Infra.Context;
using System.Collections.Generic;
using System.Linq;

namespace Clock.Infra.Repositories
{
    public class FrequencyRepository : RepositoryBase<Frequency>, IFrequencyRepository
    {
        private readonly ClockContext Db;

        public FrequencyRepository(ClockContext context) : base(context)
        {
            Db = context;
        }

        public IEnumerable<Frequency> Frequencies()
        {
            return Db.Frequency.ToList();
        }
    }
}
