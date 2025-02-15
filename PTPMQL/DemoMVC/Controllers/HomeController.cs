using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email)
        {
            ViewBag.Message = $"Hello {name}, we received your email ({email})!";
            return View();
        }
    }
}
