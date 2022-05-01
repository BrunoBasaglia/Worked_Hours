using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Application.Services
{
    public class EmployerAppService : AppServiceBase<Employer>, IEmployerAppService
    {
        public IEmployerService _employerService;

        public EmployerAppService(IEmployerService employerService) : base(employerService)
        {
            _employerService = employerService;
        }

        //public Employer Employer(string id)
        //{
        //    return _employerService.Employer(id);
        //}

        public IEnumerable<Employer> Employers()
        {
            return _employerService.Employers();
        }

        public IEnumerable<Employer> Employers(string id)
        {
            return _employerService.Employers(id);
        }

        public Employer EmployerByEmail(string email)
        {
            return _employerService.EmployerByEmail(email);
        }

        public Employer EmployerById(string id)
        {
            return _employerService.EmployerById(id);
        }
    }
}
