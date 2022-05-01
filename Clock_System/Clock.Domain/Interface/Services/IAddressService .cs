using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Services
{
    public interface IAddressService : IServiceBase<Address>
    {
        IEnumerable<Address> Addresses();
        Address Address(int id);
    }
}
