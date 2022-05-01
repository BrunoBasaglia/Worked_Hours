using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clock.Infra.Repositories
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        private readonly ClockContext Db;

        public ClientRepository(ClockContext context) : base(context)
        {
            Db = context;
        }

        public IEnumerable<Client> Clients()
        {
            return Db.Client.Include(e => e.City).ThenInclude(s => s.State).ToList();
        }

        public Client Client(string id)
        {
            return Db.Client.Include(e => e.City).ThenInclude(s => s.State).Where(h => h.IdClient == id).FirstOrDefault();
        }

        //public Employer EmployerByEmail(string email)
        //{
        //    return Db.Employer.
        //    Include(e => e.PersonEmployer).ThenInclude(pe => pe.Person).
        //    Include(p => p.City).ThenInclude(p => p.State).
        //    Include(e => e.Hours).
        //    Where(e => e.Email == email).
        //    FirstOrDefault();
        //}
        //public Employer EmployerById(string id)
        //{
        //    return Db.Employer.
        //    Include(e => e.PersonEmployer).ThenInclude(pe => pe.Person).ThenInclude(e => e.Hours).
        //    Include(p => p.City).ThenInclude(p => p.State).
        //    Where(e => e.IdEmployer == id).
        //    FirstOrDefault();
        //}
    }
}
