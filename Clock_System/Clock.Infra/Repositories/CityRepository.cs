using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Clock.Infra.Repositories
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        private readonly ClockContext Db;

        public CityRepository(ClockContext context) : base(context)
        {
            Db = context;
        }

        public IEnumerable<City> Cities()
        {
            return Db.City.
                  Include(a => a.State).
                  //ThenInclude(a => a.Addresses).
                //Include(s => s.MaritalStatus).
                //Include(s => s.Nationality).
                //Include(s => s.Wages).
                //Include(s => s.Bills).
                //Include(s => s.FamilyMembers).
                ////Include(s => m.Modelo).ThenInclude(f => f.Fabricante)
                ToList();
        }

        public City City(int id)
        {
            return Db.City.Include(c => c.State).FirstOrDefault();
        }
    }
}
