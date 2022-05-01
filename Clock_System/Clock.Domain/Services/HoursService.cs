using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Domain.Services
{
    public class HoursService : ServiceBase<Hours>, IHoursService
    {
        private IHoursRepository _hoursRepository;

        public HoursService(IHoursRepository hoursRepository) : base(hoursRepository)
        {
            _hoursRepository = hoursRepository;
        }

        public IEnumerable<Hours> Hours()
        {
            return _hoursRepository.Hours();
        }

        public Hours Hour(int id)
        {
            return _hoursRepository.Hour(id);
        }

        public void AddRange(IEnumerable<Hours> hours)
        {
             _hoursRepository.AddRange(hours);
        }

    }
}
