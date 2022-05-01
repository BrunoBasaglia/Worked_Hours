using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Application.Services
{
    public class PersonEmployerAppService : AppServiceBase<PersonEmployer>, IPersonEmployerAppService
    {
        public IPersonEmployerService _personEmployerService;

        public PersonEmployerAppService(IPersonEmployerService personEmployerService) : base(personEmployerService)
        {
            _personEmployerService = personEmployerService;
        }

        public IEnumerable<PersonEmployer> PersonEmployer()
        {
            return _personEmployerService.PersonEmployer();
        }

        public PersonEmployer PersonEmployer(string id)
        {
            return _personEmployerService.PersonEmployer(id);
        }
    }
}
