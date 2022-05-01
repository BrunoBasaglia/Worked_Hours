using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Services
{
    public interface IClientService : IServiceBase<Client>
    {
        IEnumerable<Client> Clients();
        Client Client(string id);
        //Employer EmployerByEmail(string email);
        //Employer EmployerById(string id);
    }
}
