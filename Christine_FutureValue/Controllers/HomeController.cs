using Microsoft.AspNetCore.Mvc;

namespace Christine_FutureValue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Christine";
            ViewBag.FV = 1000;
            ViewBag.Age = 35;
            return View();
        }
    }
}
