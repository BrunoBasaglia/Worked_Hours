using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clock.Infra.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        private readonly ClockContext Db;

        public PersonRepository(ClockContext context) : base(context)
        {
            Db = context;
        }

        public IEnumerable<Person> People()
        {
            return Db.Person.
                //Include(s => s.MaritalStatus).
                //Include(s => s.Nationality).
                //Include(s => s.Wages).
                //Include(s => s.Bills).
                //Include(s => s.FamilyMembers).
                ////Include(s => m.Modelo).ThenInclude(f => f.Fabricante)
                ToList();
        }
        public Person PersonById(string id)
        {
            return Db.Person.
                Include(p => p.PersonEmployer).ThenInclude(pe => pe.Employer).
                Include(p => p.City).ThenInclude(p => p.State).
                Where(p => p.IdPerson == id).
                FirstOrDefault();
        }

        public Person PersonByName(string name)
        {
            return Db.Person.
                Include(p => p.PersonEmployer).ThenInclude(pe => pe.Employer).
                Include(p => p.City).ThenInclude(p => p.State).
                Where(p => p.Email == name).
                FirstOrDefault();
        }
    }
}
