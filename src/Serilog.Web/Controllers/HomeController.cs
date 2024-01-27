using Microsoft.AspNetCore.Mvc;

namespace Serilog.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
