using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Application.Interfaces
{
    public interface ICityAppService : IAppServiceBase<City>
    {
        IEnumerable<City> Cities();
        City City(int id);
    }
}
