using AutoMapper;
using Clock.Domain.Entities;
using Clock.Presentation.ViewModels;

namespace Clock.Presentation.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Person, PersonViewModel>();
            CreateMap<PersonViewModel, Person>();

            CreateMap<Employer, EmployerViewModel>();
            CreateMap<EmployerViewModel, Employer>();

            //CreateMap<Address, AddressViewModel>();
            //CreateMap<AddressViewModel, Address>();

            CreateMap<State, StateViewModel>();
            CreateMap<StateViewModel, State>();

            CreateMap<City, CityViewModel>();
            CreateMap<CityViewModel, City>();

            CreateMap<Hours, HoursViewModel>();
            CreateMap<HoursViewModel, Hours>();

            CreateMap<PersonEmployer, PersonEmployerViewModel>();
            CreateMap<PersonEmployerViewModel, PersonEmployer>();

            CreateMap<Client, ClientViewModel>();
            CreateMap<ClientViewModel, Client>();

            CreateMap<Frequency, FrequencyViewModel>();
            CreateMap<FrequencyViewModel, Frequency>();
        }
    }
}
