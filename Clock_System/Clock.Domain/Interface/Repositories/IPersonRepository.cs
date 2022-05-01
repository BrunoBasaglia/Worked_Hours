using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Repositories
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        IEnumerable<Person> People();
        Person PersonById(string id);
        Person PersonByName(string id);
    }
}
