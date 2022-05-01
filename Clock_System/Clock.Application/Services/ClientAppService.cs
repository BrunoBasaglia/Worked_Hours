using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Application.Services
{
    public class ClientAppService : AppServiceBase<Client>, IClientAppService
    {
        public IClientService _clientService;

        public ClientAppService(IClientService clientService) : base(clientService)
        {
            _clientService = clientService;
        }

        public IEnumerable<Client> Clients()
        {
            return _clientService.Clients();
        }

        public Client Client(string id)
        {
            return _clientService.Client(id);
        }

        //public Employer EmployerByEmail(string email)
        //{
        //    return _employerService.EmployerByEmail(email);
        //}

        //public Employer EmployerById(string id)
        //{
        //    return _employerService.EmployerById(id);
        //}
    }
}
