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
    public class QuotesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IEmployerAppService _employerAppService;
        private readonly ICityAppService _cityAppService;

        public QuotesController(IMapper mapper, IEmployerAppService employerAppService, ICityAppService cityAppService)
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
            return View();
        }
    }
}
