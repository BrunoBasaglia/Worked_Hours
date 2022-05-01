using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Application.Interfaces
{
    public interface IPersonEmployerAppService : IAppServiceBase<PersonEmployer>
    {
        IEnumerable<PersonEmployer> PersonEmployer();
        PersonEmployer PersonEmployer(string id);
    }
}
