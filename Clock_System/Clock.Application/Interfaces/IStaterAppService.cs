using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Application.Interfaces
{
    public interface IStateAppService : IAppServiceBase<State>
    {
        IEnumerable<State> States();
        //Employer Employer(int id);
    }
}
