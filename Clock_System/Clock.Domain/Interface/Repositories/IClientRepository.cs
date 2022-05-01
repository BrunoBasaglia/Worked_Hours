using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Repositories
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        IEnumerable<Client> Clients();
        Client Client(string id);
        //Employer ClientByEmail(string email);
        //Employer ClientById(string id);
    }
}
