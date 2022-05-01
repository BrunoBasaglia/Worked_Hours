using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Application.Interfaces
{
    public interface IClientAppService : IAppServiceBase<Client>
    {
        IEnumerable<Client> Clients();
        Client Client(string id);
    }
}
