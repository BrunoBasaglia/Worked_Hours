using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Application.Interfaces
{
    public interface IEmployerAppService : IAppServiceBase<Employer>
    {
        IEnumerable<Employer> Employers();
        IEnumerable<Employer> Employers(string name);
        //Employer Employer(string name);
        public Employer EmployerByEmail(string email);
        public Employer EmployerById(string id);
    }
}
