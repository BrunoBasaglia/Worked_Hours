using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Services
{
    public interface IFrequencyService : IServiceBase<Frequency>
    {
        IEnumerable<Frequency> Frequencies();
    }
}
