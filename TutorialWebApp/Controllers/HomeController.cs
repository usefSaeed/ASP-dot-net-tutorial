using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TutorialWebApp.Models;

namespace TutorialWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private InstituteContext db = new InstituteContext();


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TryOutCodeFirst() { 
            var students = db.Students.ToList();
            return View(students);
        }

        public IActionResult Index()
        {
            Student student1 = new Student()
            {
                Id = 1,
                Age = 10,
                Name = "Hamamda Mohsem"
            };
            Student student2 = new Student()
            {
                Id = 2,
                Age = 12,
                Name = "Ayman Mohsem"
            };
            Student student3 = new Student()
            {
                Id = 3,
                Age = 16,
                Name = "Mostafa Mohsem"
            };
            Course course = new Course()
            {
                Name = "Arabic Course",
                Id = 1,
                Description = "For kids and adults"
            };
            Enrollment enrollment = new Enrollment()
            {
                EnrolledCourse = course,
                Students = new List<Student>{ student1, student2, student3 }
            };

            return View(enrollment);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}