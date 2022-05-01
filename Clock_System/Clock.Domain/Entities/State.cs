using System.Collections.Generic;

namespace Clock.Domain.Entities
{
    public class State
    {
        public State()
        {
        }

        public State(int id, string name, string code)
        {
            IdState = id;
            Name = name;
            Code = code;
        }

        public int IdState { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
