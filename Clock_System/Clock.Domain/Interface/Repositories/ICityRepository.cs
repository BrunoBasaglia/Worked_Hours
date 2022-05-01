using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Repositories
{
    public interface ICityRepository : IRepositoryBase<City>
    {
        IEnumerable<City> Cities();
        City City(int id);
    }
}
