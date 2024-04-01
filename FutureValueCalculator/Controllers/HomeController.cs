using Microsoft.AspNetCore.Mvc;

namespace FutureValueCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Ryan";
            ViewBag.FV = 99999.99;
            return View();
        }
    }
}
