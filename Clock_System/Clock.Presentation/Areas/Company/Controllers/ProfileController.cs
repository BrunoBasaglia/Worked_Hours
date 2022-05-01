using System;
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
    public class ProfileController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEmployerAppService _employerAppService;
        private readonly ICityAppService _cityAppService;

        public ProfileController(IMapper mapper, IEmployerAppService employerAppService, ICityAppService cityAppService)
        {
            _mapper = mapper;
            _employerAppService = employerAppService;
            _cityAppService = cityAppService;
        }

        public void Cities()
        {
            ViewBag.Cities = new SelectList(_cityAppService.Cities(), "IdCity", "Name");
        }

        [HttpGet]
        public IActionResult Index()
        {
            var email = User.Identity.Name;
            try
            {
                var employer = _employerAppService.EmployerByEmail(email);
                var employerViewModel = _mapper.Map<Employer, EmployerViewModel>(employer);
                return View(employerViewModel);
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        [HttpGet]
        public IActionResult Update()
        {
            var email = User.Identity.Name;
            try
            {
                var employer = _employerAppService.EmployerByEmail(email);
                var employerViewModel = _mapper.Map<Employer, EmployerViewModel>(employer);
                Cities();
                return View(employerViewModel);
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

        [HttpPost]
        public IActionResult Update(EmployerViewModel employerViewModel)
        {
            try
            {
                var employer = _mapper.Map<EmployerViewModel, Employer>(employerViewModel);
                _employerAppService.Update(employer);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }
    }
}
