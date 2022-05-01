using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Domain.Services
{
    public class CityService : ServiceBase<City>, ICityService
    {
        private ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository) : base(cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IEnumerable<City> Cities()
        {
            return _cityRepository.Cities();
        }

        public City City(int id)
        {
            return _cityRepository.City(id);
        }

    }
}
