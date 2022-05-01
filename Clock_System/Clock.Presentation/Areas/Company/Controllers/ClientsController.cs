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
    public class ClientsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IClientAppService _clientAppService;
        private readonly ICityAppService _cityAppService;
        private readonly IFrequencyAppService _frequencyAppService;

        public ClientsController(IMapper mapper, IClientAppService clientAppService, ICityAppService cityAppService, IFrequencyAppService frequencyAppService)
        {
            _mapper = mapper;
            _clientAppService = clientAppService;
            _cityAppService = cityAppService;
            _frequencyAppService = frequencyAppService;
        }

        public void Cities()
        {
            ViewBag.Cities = new SelectList(_cityAppService.Cities(), "IdCity", "Name");
        }

        public void Frequencies()
        {
            ViewBag.Frequencies = new SelectList(_frequencyAppService.Frequencies(), "IdFrequency", "Description");
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Client> clients = _clientAppService.Clients();
            IEnumerable<ClientViewModel> clientViewModel = _mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(clients);
            return View(clientViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Cities();
            Frequencies();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClientViewModel clientViewModel)
        {
            var client = _mapper.Map<ClientViewModel, Client>(clientViewModel);
            _clientAppService.Add(client);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            Cities();
            Frequencies();
            var client = _clientAppService.Client(id);
            var clientViewModel = _mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            Cities();
            Frequencies();
            var client = _clientAppService.Client(id);
            var clientViewModel = _mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        [HttpPost]
        public IActionResult Edit(ClientViewModel clientViewModel)
        {
            var client = _mapper.Map<ClientViewModel, Client>(clientViewModel);
            _clientAppService.Update(client);
            return RedirectToAction("Index");
        }
    }
}
