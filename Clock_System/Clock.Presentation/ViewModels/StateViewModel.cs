using Clock.Domain.Entities;
using System.Collections.Generic;

namespace Clock.Presentation.ViewModels
{
    public class StateViewModel
    {
        public StateViewModel()
        {
        }

        public StateViewModel(int id, string name, string code)
        {
            IdState = id;
            Name = name;
            Code = code;
        }

        public int IdState { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<AddressViewModel> Addresses { get; set; }
    }
}
