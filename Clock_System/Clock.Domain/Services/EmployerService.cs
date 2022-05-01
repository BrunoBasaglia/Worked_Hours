using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Domain.Services
{
    public class EmployerService : ServiceBase<Employer>, IEmployerService
    {
        private IEmployerRepository _employerRepository;

        public EmployerService(IEmployerRepository employerRepository) : base(employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public IEnumerable<Employer> Employers()
        {
            return _employerRepository.Employers();
        }

        public IEnumerable<Employer> Employers(string id)
        {
            return _employerRepository.Employers(id);
        }

        //public Employer Employer(string id)
        //{
        //    return _employerRepository.Employer(id);
        //}

        public Employer EmployerByEmail(string email)
        {
            return _employerRepository.EmployerByEmail(email);
        }

        public Employer EmployerById(string id)
        {
            return _employerRepository.EmployerById(id);
        }
    }
}
