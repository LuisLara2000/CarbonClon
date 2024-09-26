using Microsoft.AspNetCore.Mvc;

namespace carbonClon.Controllers
{
    public class CarbonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
