using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Domain.Services
{
    public class AddressService : ServiceBase<Address>, IAddressService
    {
        private IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository) : base(addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public IEnumerable<Address> Addresses()
        {
            return _addressRepository.Addresses();
        }

        public Address Address(int id)
        {
            return _addressRepository.Address(id);
        }

    }
}
