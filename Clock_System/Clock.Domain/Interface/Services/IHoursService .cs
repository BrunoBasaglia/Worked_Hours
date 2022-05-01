using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Services
{
    public interface IHoursService : IServiceBase<Hours>
    {
        void AddRange(IEnumerable<Hours> hours);
        IEnumerable<Hours> Hours();
        Hours Hour(int id);
    }
}
