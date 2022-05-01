using System.Collections.Generic;

namespace Clock.Presentation.ViewModels
{
    public class CityViewModel
    {
        //public CityViewModel()
        //{

        //}

        //public CityViewModel(string name, int state)
        //{
        //    Name = name;
        //    StateFk = state;
        //}

        //public CityViewModel(int id, string name, int state)
        //{
        //    IdCity = id;
        //    Name = name;
        //    StateFk = state;
        //}

        public int IdCity { get; set; }
        public string Name { get; set; }
        public int StateFk { get; set; }
        public StateViewModel State { get; set; }
        public ICollection<PersonViewModel> People { get; set; }
        public ICollection<EmployerViewModel> Employers { get; set; }
    }
}
