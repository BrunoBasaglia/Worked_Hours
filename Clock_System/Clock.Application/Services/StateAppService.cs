using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Domain.Interface.Services;
using System.Collections.Generic;

namespace Clock.Application.Services
{
    public class StateAppService : AppServiceBase<State>, IStateAppService
    {
        public IStateService _stateService;

        public StateAppService(IStateService stateService) : base(stateService)
        {
            _stateService = stateService;
        }

        //public Employer Employer(int id)
        //{
        //    return _employerService.Employer(id);
        //}

        public IEnumerable<State> States()
        {
            return _stateService.States();
        }
    }
}
