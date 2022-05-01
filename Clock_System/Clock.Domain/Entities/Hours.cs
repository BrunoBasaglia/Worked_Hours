using System;

namespace Clock.Domain.Entities
{
    public class Hours
    {
        public int IdHour { get; set; }
        public DateTime Day { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public double Hour { get; set; }
        public string Description { get; set; }
        public Employer Employer { get; set; }
        public string EmployerFk { get; set; }
        public Person Person { get; set; }
        public string PersonFk { get; set; }
    }
}
