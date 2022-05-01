using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clock.Infra.Repositories
{
    public class PersonEmployerRepository : RepositoryBase<PersonEmployer>, IPersonEmployerRepository
    {
        private readonly ClockContext Db;

        public PersonEmployerRepository(ClockContext context) : base(context)
        {
            Db = context;
        }

        public IEnumerable<PersonEmployer> PersonEmployer()
        {
            return Db.PersonEmployer.
                Include(p => p.Person).
                Include(e => e.Employer).
                //Include(s => s.Wages).
                //Include(s => s.Bills).
                //Include(s => s.FamilyMembers).
                ////Include(s => m.Modelo).ThenInclude(f => f.Fabricante)
                ToList();
        }

        public PersonEmployer PersonEmployer(string id)
        {
            return Db.PersonEmployer.
               //  Include(p => p.Person).
               // Include(e => e.Employer).
                Where(pe => pe.IdPerson == id).
                FirstOrDefault();
        }
    }
}
