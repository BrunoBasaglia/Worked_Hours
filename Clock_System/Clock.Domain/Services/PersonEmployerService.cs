using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Domain.Services
{
    public class PersonEmployerService : ServiceBase<PersonEmployer>, IPersonEmployerService
    {
        private IPersonEmployerRepository _personEmployerRepository;

        public PersonEmployerService(IPersonEmployerRepository personEmployerRepository) : base(personEmployerRepository)
        {
            _personEmployerRepository = personEmployerRepository;
        }

        public IEnumerable<PersonEmployer> PersonEmployer()
        {
            return _personEmployerRepository.PersonEmployer();
        }
        
        public PersonEmployer PersonEmployer(string id)
        {
            return _personEmployerRepository.PersonEmployer(id);
        }

    }
}
