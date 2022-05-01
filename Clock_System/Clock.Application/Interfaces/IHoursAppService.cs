using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Application.Interfaces
{
    public interface IHoursAppService : IAppServiceBase<Hours>
    {
        void AddRange(IEnumerable<Hours> hours);
        IEnumerable<Hours> Hours();
        Hours Hour(int id);
    }
}
