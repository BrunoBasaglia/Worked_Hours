using System.Collections.Generic;

namespace Clock.Presentation.ViewModels
{
    public class FrequencyViewModel
    {
        public int IdFrequency { get; set; }
        public string Description { get; set; }
        public ICollection<ClientViewModel> Clients { get; set; }
    }
}
