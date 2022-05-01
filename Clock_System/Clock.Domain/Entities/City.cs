using System;
using System.Collections.Generic;
using System.Text;

namespace Clock.Domain.Entities
{
    public class City
    {
        public City()
        {

        }

        public City(string name, int state)
        {
            Name = name;
            StateFk = state;
        }

        public City(int id, string name, int state)
        {
            IdCity = id;
            Name = name;
            StateFk = state;
        }

        public int IdCity { get; set; }
        public string Name { get; set; }
        public int StateFk { get; set; }
        public State State { get; set; }
        public ICollection<Person> People { get; set; }
        public ICollection<Employer> Employers { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
