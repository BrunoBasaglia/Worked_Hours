using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Domain.Services
{
    public class ClientService : ServiceBase<Client>, IClientService
    {
        private IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository) : base(clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> Clients()
        {
            return _clientRepository.Clients();
        }

        public Client Client(string id)
        {
            return _clientRepository.Client(id);
        }

        //public Employer EmployerByEmail(string email)
        //{
        //    return _employerRepository.EmployerByEmail(email);
        //}

        //public Employer EmployerById(string id)
        //{
        //    return _employerRepository.EmployerById(id);
        //}
    }
}
