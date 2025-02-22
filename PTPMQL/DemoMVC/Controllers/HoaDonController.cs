using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class HoaDonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(HoaDonModel model)
        {
            double tongTien = model.SoLuong * model.DonGia;
            ViewBag.TongTien = tongTien.ToString("N0") + " VND";

            return View();
        }
    }
}
