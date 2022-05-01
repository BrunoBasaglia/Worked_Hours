using System;

namespace Clock.Presentation.ViewModels
{
    public class HoursViewModel
    {
        public int IdHour { get; set; }
        public DateTime Day { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public double Hour { get; set; }
        public string Description { get; set; }
        public EmployerViewModel Employer { get; set; }
        public string EmployerFk { get; set; }
        public PersonViewModel Person { get; set; }
        public string PersonFk { get; set; }
    }
}
