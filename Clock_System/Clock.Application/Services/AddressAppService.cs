using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Application.Services
{
    public class AddressAppService : AppServiceBase<Address>, IAddressAppService
    {
        public IAddressService _addressService;

        public AddressAppService(IAddressService addressService) : base(addressService)
        {
            _addressService = addressService;
        }

        public Address Address(int id)
        {
            return _addressService.Address(id);
        }

        public IEnumerable<Address> Addresses()
        {
            return _addressService.Addresses();
        }

    }
}
