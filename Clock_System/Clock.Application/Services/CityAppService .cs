using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Application.Services
{
    public class CityAppService : AppServiceBase<City>, ICityAppService
    {
        public ICityService _cityService;

        public CityAppService(ICityService cityService) : base(cityService)
        {
            _cityService = cityService;
        }

        public City City(int id)
        {
            return _cityService.City(id);
        }

        public IEnumerable<City> Cities()
        {
            return _cityService.Cities();
        }

    }
}
