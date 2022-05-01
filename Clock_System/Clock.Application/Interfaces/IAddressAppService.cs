using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Application.Interfaces
{
    public interface IAddressAppService : IAppServiceBase<Address>
    {
        IEnumerable<Address> Addresses();
        Address Address(int id);
    }
}
