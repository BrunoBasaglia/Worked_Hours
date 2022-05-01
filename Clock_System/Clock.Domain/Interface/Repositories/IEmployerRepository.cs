using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Repositories
{
    public interface IEmployerRepository : IRepositoryBase<Employer>
    {
        IEnumerable<Employer> Employers();
        IEnumerable<Employer> Employers(string name);
        //Employer Employer(string name);
        Employer EmployerByEmail(string email);
        Employer EmployerById(string id);
    }
}
