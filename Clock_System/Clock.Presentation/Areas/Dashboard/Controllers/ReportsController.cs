using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clock.Presentation.Areas.Dashboard.Controllers
{
    [Area(nameof(Dashboard))]  
    [Route("Dashboard/[controller]/[action]")]
    [Authorize]
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            NewUser();
            return View();
        }

        public bool NewUser()
        {

            return true;
        }






    }
}
