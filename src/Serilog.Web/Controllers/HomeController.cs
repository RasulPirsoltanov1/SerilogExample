using Microsoft.AspNetCore.Mvc;

namespace SerilogExample.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
