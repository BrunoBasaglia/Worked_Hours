using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Domain.Interface.Repositories
{
    public interface IStateRepository : IRepositoryBase<State>
    {
        IEnumerable<State> States();
        //State State(int id);
    }
}
