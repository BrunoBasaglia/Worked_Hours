using System;
using System.Collections.Generic;

namespace Clock.Domain.Entities
{
    public class Person
    {
        public string IdPerson { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public string Telephone { get; set; }
        public long ABN { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public int ZipCode { get; set; }
        public City City { get; set; }
        public int CityFk { get; set; }
        public ICollection<Hours> Hours { get; set; }
        public ICollection<PersonEmployer> PersonEmployer { get; set; }
        public bool IsNew { get; set; }
        public decimal Wages { get; set; }
        public string Function { get; set; }
    }
}
