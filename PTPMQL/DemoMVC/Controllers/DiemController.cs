using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class DiemController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DiemModel model)
        {
            double finalScore = (model.A * 0.6) + (model.B * 0.3) + (model.C * 0.1);
            string grade;

            if (finalScore >= 8.5)
                grade = "A+";
            else if (finalScore >= 7.0)
                grade = "B";
            else if (finalScore >= 5.0)
                grade = "C";
            else
                grade = "D";

            ViewBag.FinalScore = finalScore.ToString("0.00");
            ViewBag.Grade = grade;

            return View();
        }
    }
}
