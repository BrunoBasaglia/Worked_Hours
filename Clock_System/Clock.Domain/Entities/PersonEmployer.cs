namespace Clock.Domain.Entities
{
    public class PersonEmployer
    {
        public string IdPerson { get; set; }
        public Person Person { get; set; }
        public string IdEmployer { get; set; }
        public Employer Employer { get; set; }
    }
}
