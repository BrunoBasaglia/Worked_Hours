using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Services
{
    public interface IPersonService : IServiceBase<Person>
    {
        IEnumerable<Person> People();
        Person PersonById(string id);
        Person PersonByName(string name);
    }
}
