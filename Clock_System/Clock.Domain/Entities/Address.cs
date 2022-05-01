using System.Collections.Generic;

namespace Clock.Domain.Entities
{
    public class Address
    {
        public Address()
        {
        }

        public Address(string line, string suburb, string city, int zipCode, int state)
        {
            Line = line;
            Suburb = suburb;
            City = city;
            ZipCode = zipCode;
            StateFk = state;
        }

        public Address(int id, string line, string suburb, string city, int zipCode, int state)
        {
            IdAddress = id;
            Line = line;
            Suburb = suburb;
            City = city;
            ZipCode = zipCode;
            StateFk = state;
        }

        public int IdAddress { get; set; }
        public string Line { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public State State { get; set; }
        public int StateFk { get; set; }
        public ICollection<Person> People { get; set; }
        public ICollection<Employer> Employers { get; set; }
    }
}
