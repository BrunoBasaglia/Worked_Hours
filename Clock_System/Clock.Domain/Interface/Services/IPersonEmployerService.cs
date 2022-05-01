using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Services
{
    public interface IPersonEmployerService : IServiceBase<PersonEmployer>
    {
        IEnumerable<PersonEmployer> PersonEmployer();
        //IEnumerable<PersonEmployer> PersonEmployer(string id);
        PersonEmployer PersonEmployer(string id);
    }
}
