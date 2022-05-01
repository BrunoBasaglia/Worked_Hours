using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clock.Infra.Repositories
{
    public class StateRepository : RepositoryBase<State>, IStateRepository
    {
        private readonly ClockContext Db;

        public StateRepository(ClockContext context) : base(context)
        {
            Db = context;
        }

        public IEnumerable<State> States()
        {
            return Db.State.
               // Include(s => s.Addresses).
                //Include(s => s.Nationality).
                //Include(s => s.Wages).
                //Include(s => s.Bills).
                //Include(s => s.FamilyMembers).
                ////Include(s => m.Modelo).ThenInclude(f => f.Fabricante)
                ToList();
        }

        //public Employer Employer(int id)
        //{
        //    return Db.Employer.FirstOrDefault();
        //}
    }
}
