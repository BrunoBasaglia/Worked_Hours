using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Repositories
{
    public interface IFrequencyRepository : IRepositoryBase<Frequency>
    {
        IEnumerable<Frequency> Frequencies();
    }
}
