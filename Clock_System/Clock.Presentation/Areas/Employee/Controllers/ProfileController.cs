using System;
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
    public class ProfileController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPersonAppService _personAppService;
        private readonly ICityAppService _cityAppService;

        public ProfileController(IMapper mapper, IPersonAppService personAppService, ICityAppService cityAppService)
        {
            _mapper = mapper;
            _personAppService = personAppService;
            _cityAppService = cityAppService;
        }

        public void Cities()
        {
            ViewBag.Cities = new SelectList(_cityAppService.Cities(), "IdCity", "Name");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var name = User.Identity.Name;
            try
            {
                var person = _personAppService.PersonByName(name);
                var personViewModel = _mapper.Map<Person, PersonViewModel>(person);
                return View(personViewModel);
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public IActionResult Update()
        {
            var name = User.Identity.Name;
            try
            {
                var person = _personAppService.PersonByName(name);
                var personViewModel = _mapper.Map<Person, PersonViewModel>(person);
                Cities();
                return View(personViewModel);
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public IActionResult Update(PersonViewModel personViewModel)
        {
            try
            {
                var person = _mapper.Map<PersonViewModel, Person>(personViewModel);
                _personAppService.Update(person);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }
    }
}
