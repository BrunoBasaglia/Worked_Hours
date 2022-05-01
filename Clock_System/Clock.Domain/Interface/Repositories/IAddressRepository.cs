using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Repositories
{
    public interface IAddressRepository : IRepositoryBase<Address>
    {
        IEnumerable<Address> Addresses();
        Address Address(int id);
    }
}
