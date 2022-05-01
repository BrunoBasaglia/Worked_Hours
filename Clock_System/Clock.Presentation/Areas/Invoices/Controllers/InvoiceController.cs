using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clock.Presentation.Areas.Invoice.Controllers
{
    [Area(nameof(Invoice))]
    [Route("Invoice/[controller]/[action]")]
    [Authorize]
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
