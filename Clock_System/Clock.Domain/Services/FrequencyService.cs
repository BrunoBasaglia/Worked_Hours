using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Domain.Services
{
    public class FrequencyService : ServiceBase<Frequency>, IFrequencyService
    {
        private IFrequencyRepository _frequencyRepository;

        public FrequencyService(IFrequencyRepository frequencyRepository) : base(frequencyRepository)
        {
            _frequencyRepository = frequencyRepository;
        }

        public IEnumerable<Frequency> Frequencies()
        {
            return _frequencyRepository.Frequencies();
        }
    }
}
