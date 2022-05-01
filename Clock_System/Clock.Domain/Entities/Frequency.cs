using System.Collections.Generic;

namespace Clock.Domain.Entities
{
    public class Frequency
    {
        public Frequency()
        {

        }

        public Frequency(int id, string description)
        {
            IdFrequency = id;
            Description = description;
        }

        public int IdFrequency { get; set; }
        public string Description { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
