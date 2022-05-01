using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Application.Interfaces
{
    public interface IPersonAppService : IAppServiceBase<Person>
    {
        IEnumerable<Person> People();
        Person PersonById(string id);
        Person PersonByName(string name);
    }
}
