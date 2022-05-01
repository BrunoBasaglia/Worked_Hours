using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Application.Interfaces
{
    public interface IFrequencyAppService : IAppServiceBase<Frequency>
    {
        IEnumerable<Frequency> Frequencies();
    }
}
