using System;
using System.Collections.Generic;
using AutoMapper;
using Clock.Application.Interfaces;
using Clock.Domain.Entities;
using Clock.Presentation.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clock.Presentation.Areas.Company.Controllers
{
    [Area(nameof(Company))]
    [Route("Company/[controller]/[action]")]
    [Authorize]
    public class EmployeesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEmployerAppService _employerAppService;
        private readonly ICityAppService _cityAppService;
        private readonly IPersonEmployerAppService _personEmployerAppService;
        private readonly IPersonAppService _personAppService;

        public EmployeesController(IMapper mapper, IEmployerAppService employerAppService, ICityAppService cityAppService, IPersonEmployerAppService personEmployerAppService, IPersonAppService personAppService)
        {
            _mapper = mapper;
            _employerAppService = employerAppService;
            _cityAppService = cityAppService;
            _personEmployerAppService = personEmployerAppService;
            _personAppService = personAppService;
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
                //IEnumerable<PersonEmployer> personEmployer = _personEmployerAppService.PersonEmployer();
                //var personEmployerViewModel = _mapper.Map<IEnumerable<PersonEmployer>, IEnumerable<PersonEmployerViewModel>>(personEmployer);

                IEnumerable<PersonEmployer> personEmployer = _personEmployerAppService.PersonEmployer();
                //List<PersonEmployerViewModel> listPe = new List<PersonEmployerViewModel>();

                //foreach (var pe in personEmployer)
                //{
                //    var personEmployerViewModel = _mapper.Map<PersonEmployer,PersonEmployerViewModel>(pe);
                //    listPe.Add(personEmployerViewModel);
                //}


                IEnumerable<PersonEmployerViewModel> personEmployerViewModel = _mapper.Map<IEnumerable<PersonEmployer>, IEnumerable<PersonEmployerViewModel>>(personEmployer);
                return View(personEmployerViewModel);
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

                var person = _personAppService.PersonById(id);
                var personViewModel = _mapper.Map<Person, PersonViewModel>(person);
                return View(personViewModel);
            }
            catch (Exception e)
            {
                return View("Error");
            }

        }

            [HttpGet]
        public IActionResult Invite()
        {
            return View();
            //var name = User.Identity.Name;
            //try
            //{
            //    var employer = _employerAppService.Employer(name);
            //    var employerViewModel = _mapper.Map<Employer, EmployerViewModel>(employer);
            //    Cities();
            //    return View(employerViewModel);
            //}
            //catch (Exception e)
            //{
            //    return View("Error");
            //}
        }

        //[HttpGet]
        //public IActionResult Update()
        //{
        //    var name = User.Identity.Name;
        //    try
        //    {
        //        var employer = _employerAppService.Employer(name);
        //        var employerViewModel = _mapper.Map<Employer, EmployerViewModel>(employer);
        //        Cities();
        //        return View(employerViewModel);
        //    }
        //    catch (Exception e)
        //    {
        //        return View("Error");
        //    }
        //}

        //[HttpPost]
        //public IActionResult Update(EmployerViewModel employerViewModel)
        //{
        //    try
        //    {
        //        var employer = _mapper.Map<EmployerViewModel, Employer>(employerViewModel);
        //        _employerAppService.Update(employer);
        //        return RedirectToAction("Index");
        //    }
        //    catch (Exception e)
        //    {
        //        return View("Error");
        //    }
        //}
    }
}
