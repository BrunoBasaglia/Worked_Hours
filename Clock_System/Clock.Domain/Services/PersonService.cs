using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Domain.Services
{
    public class PersonService : ServiceBase<Person>, IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository) : base(personRepository)
        {
            _personRepository = personRepository;
        }

        public IEnumerable<Person> People()
        {
            return _personRepository.People();
        }

        public Person PersonById(string id)
        {
            return _personRepository.PersonById(id);
        }

        public Person PersonByName(string name)
        {
            return _personRepository.PersonByName(name);
        }

    }
}
