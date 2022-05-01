using System;

namespace Clock.Domain.Entities
{
    public class Client
    {
        public string IdClient { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MyProperty { get; set; }
        public DateTime DOB { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public int ZipCode { get; set; }
        public City City { get; set; }
        public int CityFk { get; set; }
        public Frequency Frequency { get; set; }
        public int FrequencyFK { get; set; }
    }
}
