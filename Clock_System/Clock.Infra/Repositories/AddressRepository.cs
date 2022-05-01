//using Clock.Domain.Entities;
//using Clock.Domain.Interface.Repositories;
//using Clock.Infra.Context;
//using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;
//using System.Linq;

//namespace Clock.Infra.Repositories
//{
//    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
//    {
//        private readonly ClockContext Db;

//        public AddressRepository(ClockContext context) : base(context)
//        {
//            Db = context;
//        }

//        public IEnumerable<Address> Addresses()
//        {
//            return Db.Address.
//                  Include(a => a.State).
//                //ThenInclude(a => a.Addresses).
//                //Include(s => s.MaritalStatus).
//                //Include(s => s.Nationality).
//                //Include(s => s.Wages).
//                //Include(s => s.Bills).
//                //Include(s => s.FamilyMembers).
//                ////Include(s => m.Modelo).ThenInclude(f => f.Fabricante)
//                ToList();
//        }

//        public Address Address(int id)
//        {
//            return Db.Address.Include(a => a.State).FirstOrDefault();
//        }
//    }
//}
