using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clock.Infra.Repositories
{
    public class EmployerRepository : RepositoryBase<Employer>, IEmployerRepository
    {
        private readonly ClockContext Db;

        public EmployerRepository(ClockContext context) : base(context)
        {
            Db = context;
        }

        public IEnumerable<Employer> Employers()
        {
            return Db.Employer.
                 Include(e => e.City).ThenInclude(s => s.State).
            //Include(s => s.MaritalStatus).
            //Include(s => s.Nationality).
            //Include(s => s.Wages).
            //Include(s => s.Bills).
            //Include(s => s.FamilyMembers).
            ////Include(s => m.Modelo).ThenInclude(f => f.Fabricante)
            ToList();
        }

        public IEnumerable<Employer> Employers(string name)
        {
            var x = Db.Employer.
                Include(e => e.City).
                Include(e => e.PersonEmployer).ThenInclude(pe => pe.Person).
                Include(e => e.Hours.Select(h => h.Hour)).Where(h => h.IdEmployer == name).ToList().
            ToList();
            return x;
        }

        public Employer EmployerByEmail(string email)
        {
            return Db.Employer.
            Include(e => e.PersonEmployer).ThenInclude(pe => pe.Person).
            Include(p => p.City).ThenInclude(p => p.State).
            Include(e => e.Hours).
            Where(e => e.Email == email).
            FirstOrDefault();
        }
        public Employer EmployerById(string id)
        {
            return Db.Employer.
            Include(e => e.PersonEmployer).ThenInclude(pe => pe.Person).ThenInclude(e => e.Hours).
            Include(p => p.City).ThenInclude(p => p.State).
            Where(e => e.IdEmployer == id).
            FirstOrDefault();
        }
    }
}
