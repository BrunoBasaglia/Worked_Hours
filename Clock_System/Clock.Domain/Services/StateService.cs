using Clock.Domain.Entities;
using Clock.Domain.Interface.Repositories;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Domain.Services
{
    public class StateService : ServiceBase<State>, IStateService
    {
        private IStateRepository _stateRepository;

        public StateService(IStateRepository stateRepository) : base(stateRepository)
        {
            _stateRepository = stateRepository;
        }

        public IEnumerable<State> States()
        {
            return _stateRepository.States();
        }

        //public Employer Employer(int id)
        //{
        //    return _stateRepository.Employer(id);
        //}

    }
}
