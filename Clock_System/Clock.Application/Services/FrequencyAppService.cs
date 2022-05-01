using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Application.Services
{
    public class FrequencyAppService : AppServiceBase<Frequency>, IFrequencyAppService
    {
        public IFrequencyService _frequenciesService;

        public FrequencyAppService(IFrequencyService frequenciesService) : base(frequenciesService)
        {
            _frequenciesService = frequenciesService;
        }

        public IEnumerable<Frequency> Frequencies()
        {
            return _frequenciesService.Frequencies();
        }
    }
}
