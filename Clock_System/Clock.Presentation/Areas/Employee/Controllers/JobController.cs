using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Presentation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clock.Presentation.Areas.Employee.Controllers
{
    [Area(nameof(Employee))]
    [Route("Employee/[controller]/[action]")]
    [Authorize]
    public class JobController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPersonAppService _personAppService;
        private readonly IEmployerAppService _employerAppService;
        private readonly ICityAppService _cityAppService;
        private readonly IHoursAppService _hoursAppService;

        public JobController(IMapper mapper, IPersonAppService personAppService, IEmployerAppService employerAppService,
            ICityAppService cityAppService, IHoursAppService hoursAppService)
        {
            _personAppService = personAppService;
            _employerAppService = employerAppService;
            _cityAppService = cityAppService;
            _mapper = mapper;
            _hoursAppService = hoursAppService;
        }
        public void Cities()
        {
            ViewBag.Cities = new SelectList(_cityAppService.Cities(), "IdCity", "Name");
        }

        public IActionResult Index()
        {
            var userName = User.Identity.Name;
            var user = _personAppService.PersonByName(userName);
            var employers = _employerAppService.Employers();

            if (employers.Count() == 0)
            {
                return View();
            }


            var employersViewModel = _mapper.Map<IEnumerable<Employer>, IEnumerable<EmployerViewModel>>(employers);
            return View(employersViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Cities();
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployerViewModel employerViewModel)
        {
            try
            {
                var employer = _mapper.Map<EmployerViewModel, Employer>(employerViewModel);
                _employerAppService.Add(employer);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            try
            {
                Cities();

                var employer = _employerAppService.EmployerById(id);
                var employerViewModel = _mapper.Map<Employer, EmployerViewModel>(employer);
                return View(employerViewModel);
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public IActionResult AddHours(string id)
        {
            try
            {
                //Cities();
                var employer = _employerAppService.EmployerById(id);
                var employerViewModel = _mapper.Map<Employer, EmployerViewModel>(employer);
                var person = _personAppService.PersonByName(User.Identity.Name);
                var personViewModel = _mapper.Map<Person, PersonViewModel>(person);

                var hoursViewModel = new HoursViewModel
                {
                    Day = DateTime.Now,
                    Employer = employerViewModel,
                    Person = personViewModel
                };

                return View(hoursViewModel);
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public ActionResult AddHours([FromBody] List<TableHours> tableHours)
        {
            Hours hours;
            var listHours = new List<Hours>();

            try
            {
                foreach (var hour in tableHours)
                {
                    hours = new Hours
                    {
                        EmployerFk = hour.IdEmployer,
                        Day = Convert.ToDateTime(hour.Day),
                        Start = Convert.ToDateTime(hour.Start),
                        Finish = Convert.ToDateTime(hour.Finish),
                        Hour = (Convert.ToDateTime(hour.Finish) - Convert.ToDateTime(hour.Start)).TotalHours,
                        Description = hour.Description,
                        PersonFk = hour.IdPerson
                    };

                    //listHours.Add(hours);

                    _hoursAppService.Add(hours);
                }


                // _hoursAppService.AddRange(listHours);

                return View();
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }


    }
}
