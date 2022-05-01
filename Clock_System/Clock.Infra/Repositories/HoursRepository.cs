using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clock.Infra.Repositories
{
    public class HoursRepository : RepositoryBase<Hours>, IHoursRepository
    {
        private readonly ClockContext Db;

        public HoursRepository(ClockContext context) : base(context)
        {
            Db = context;
        }

        public void AddRange(IEnumerable<Hours> hours)
        {
            Db.Hours.
               //Include(a => a.State).
               //ThenInclude(a => a.Addresses).
               //Include(s => s.MaritalStatus).
               //Include(s => s.Nationality).
               //Include(s => s.Wages).
               //Include(s => s.Bills).
               //Include(s => s.FamilyMembers).
               ////Include(s => m.Modelo).ThenInclude(f => f.Fabricante)
               AddRange();
        }

        public IEnumerable<Hours> Hours()
        {
            return Db.Hours.
                //Include(a => a.State).
                //ThenInclude(a => a.Addresses).
                //Include(s => s.MaritalStatus).
                //Include(s => s.Nationality).
                //Include(s => s.Wages).
                //Include(s => s.Bills).
                //Include(s => s.FamilyMembers).
                ////Include(s => m.Modelo).ThenInclude(f => f.Fabricante)
                ToList();
        }

        public Hours Hour(int id)
        {
            return Db.Hours.FirstOrDefault();
        }
    }
}
