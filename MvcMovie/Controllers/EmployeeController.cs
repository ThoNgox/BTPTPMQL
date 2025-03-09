using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            var employee = new Employee
            {
                EmployeeId = "E001",
                PersonId = "P003",
                FullName = "Lê Văn C",
                Address = "Đà Nẵng",
                Age = 30
            };
            return View(employee);
        }

        public IActionResult Profile()
        {
            var employee = new Employee
            {
                EmployeeId = "E002",
                PersonId = "P004",
                FullName = "Phạm Thị D",
                Address = "Hải Phòng",
                Age = 28
            };
            return View(employee);
        }
    }
}
