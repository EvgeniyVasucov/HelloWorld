using LessonASPNET.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LessonASPNET.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<EmployeeView> Employees = new()
        {
            new EmployeeView{Id=1, LastName="Ivanov", FirstName = "Kolia", Patronymic = "Ivanovil", Age = 35},
            new EmployeeView{Id=2, LastName="Petrov", FirstName = "Ivan", Patronymic = "Ivonovich", Age = 25},
            new EmployeeView{Id=3, LastName="Siforov", FirstName = "Afsha", Patronymic = "Avanovich", Age = 26 },
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmployees()
        {
            return View(Employees);
        }
    }
}
