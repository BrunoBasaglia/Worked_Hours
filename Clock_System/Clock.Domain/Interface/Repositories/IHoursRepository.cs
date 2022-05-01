using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Repositories
{
    public interface IHoursRepository : IRepositoryBase<Hours>
    {
        void AddRange(IEnumerable<Hours> hours);
        IEnumerable<Hours> Hours();
        Hours Hour(int id);
    }
}
