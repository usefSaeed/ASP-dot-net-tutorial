using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutorialWebAppY.Models;

namespace TutorialWebAppY.Controllers
{
    public class HomeController : Controller
    {
        private InstituteContext db = new InstituteContext();

        public ActionResult TryOutCodeFirst()
        {
            List<Student> students = db.Students.ToList();
            return View(students);
        }

        public ActionResult Index()
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
                Students = new List<Student> { student1, student2, student3 }
            };

            return View(enrollment);
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