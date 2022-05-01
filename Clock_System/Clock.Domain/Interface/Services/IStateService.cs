using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Services
{
    public interface IStateService : IServiceBase<State>
    {
        IEnumerable<State> States();
        //State State(int id);
    }
}
