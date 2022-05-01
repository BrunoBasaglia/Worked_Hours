using Clock.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clock.Presentation.ViewModels
{
    public class AddressViewModel
    {

        public AddressViewModel()
        {
        }

        //public AddressViewModel(string line, string suburb, string city, int zipCode, int state)
        //{
        //    Line = line;
        //    Suburb = suburb;
        //    City = city;
        //    ZipCode = zipCode;
        //    StateFk = state;
        //}

        //public AddressViewModel(int id, string line, string suburb, string city, int zipCode, int state)
        //{
        //    IdAddress = id;
        //    Line = line;
        //    Suburb = suburb;
        //    City = city;
        //    ZipCode = zipCode;
        //    StateFk = state;
        //}


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAddress { get; set; }
        public string Line { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public virtual StateViewModel State { get; set; }
        public int StateFk { get; set; }
        public virtual ICollection<PersonViewModel> People { get; set; }
        public virtual ICollection<EmployerViewModel> Employers { get; set; }


    }
}
