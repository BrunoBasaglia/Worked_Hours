using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Repositories
{
    public interface IPersonEmployerRepository : IRepositoryBase<PersonEmployer>
    {
        IEnumerable<PersonEmployer> PersonEmployer();
        PersonEmployer PersonEmployer(string id);
    }
}
