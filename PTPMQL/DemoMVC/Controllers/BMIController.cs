using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMIModel model)
        {
            double bmi = model.Weight / (model.Height * model.Height);
            string result;

            if (bmi < 18.5)
                result = "Gầy";
            else if (bmi < 24.9)
                result = "Bình thường";
            else if (bmi < 29.9)
                result = "Thừa cân";
            else
                result = "Béo phì";

            ViewBag.BMI = bmi.ToString("0.00");
            ViewBag.Result = result;

            return View();
        }
    }
}
