using System.Collections.Generic;

namespace Clock.Presentation.ViewModels
{
    public class EmployerViewModel
    {
        public string IdEmployer { get; set; }
        public string CompanyName { get; set; }
        public int Telephone { get; set; }
        public long ABN { get; set; }
        public string Email { get; set; }
        public int Rate { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public int ZipCode { get; set; }
        public int AddressFk { get; set; }
        public CityViewModel City { get; set; }
        public int CityFk { get; set; }
        public ICollection<PersonEmployerViewModel> PersonEmployer { get; set; }
        public ICollection<HoursViewModel> Hours { get; set; }
        public bool IsNew { get; set; }
        public string PayDay { get; set; }
        public string PaymentFrequency { get; set; }
        public string PayBy { get; set; }
    }
}
