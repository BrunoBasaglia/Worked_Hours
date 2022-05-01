using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Application.Services
{
    public class HoursAppService : AppServiceBase<Hours>, IHoursAppService
    {
        public IHoursService _hoursService;

        public HoursAppService(IHoursService hoursService) : base(hoursService)
        {
            _hoursService = hoursService;
        }

        public Hours Hour(int id)
        {
            return _hoursService.Hour(id);
        }

        public IEnumerable<Hours> Hours()
        {
            return _hoursService.Hours();
        }

        public void AddRange(IEnumerable<Hours> hours)
        {
            _hoursService.AddRange(hours);
        }
    }
}
