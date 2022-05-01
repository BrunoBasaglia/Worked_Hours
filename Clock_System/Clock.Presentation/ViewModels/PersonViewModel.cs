using System;
using System.Collections.Generic;

namespace Clock.Presentation.ViewModels
{
    public class PersonViewModel
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
        public CityViewModel City { get; set; }
        public int CityFk { get; set; }
        public ICollection<PersonEmployerViewModel> PersonEmployer { get; set; }
        public ICollection<HoursViewModel> Hours { get; set; }
        public bool IsNew { get; set; }
        public decimal Wages { get; set; }
        public string Function { get; set; }
    }
}
