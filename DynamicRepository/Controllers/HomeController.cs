using System;
using System.Web.Mvc;
using DynamicRepository.Models;
using DynamicRepository.Models.Services.Interfaces;

namespace DynamicRepository.Controllers
{    
    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;

        public HomeController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public ActionResult Index()
        {
            _studentService.Add(new Student {Id = Guid.NewGuid(), FirstName = "Nguyen", LastName = "An"});
            _studentService.SaveChanges();

            var student = _studentService.FindByName("Nguyen Another thing new to commit");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}