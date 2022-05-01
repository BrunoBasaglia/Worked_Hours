using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Services
{
    public interface IEmployerService : IServiceBase<Employer>
    {
        IEnumerable<Employer> Employers();
        IEnumerable<Employer> Employers(string id);
        //Employer Employer(string id);
        Employer EmployerByEmail(string email);
        Employer EmployerById(string id);
    }
}
