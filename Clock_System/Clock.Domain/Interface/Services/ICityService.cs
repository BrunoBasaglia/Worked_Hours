using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Services
{
    public interface ICityService : IServiceBase<City>
    {
        IEnumerable<City> Cities();
        City City(int id);
    }
}
