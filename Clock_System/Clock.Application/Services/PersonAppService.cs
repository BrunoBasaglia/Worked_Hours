using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clock.Application.Services
{
    public class PersonAppService : AppServiceBase<Person>, IPersonAppService
    {
        public IPersonService _personService;

        public PersonAppService(IPersonService personService) : base(personService)
        {
            _personService = personService;
        }

        public IEnumerable<Person> People()
        {
            return _personService.People();
        }

        public Person PersonById(string id)
        {
            return _personService.PersonById(id);
        }
        public Person PersonByName(string name)
        {
            return _personService.PersonByName(name);
        }

    }
}
