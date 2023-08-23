using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TutorialWebAppY.Models
{
    public class InstituteInitializer : DropCreateDatabaseIfModelChanges<InstituteContext>
    {
        protected override void Seed(InstituteContext context)
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

            Student student4 = new Student()
            {
                Id = 4,
                Age = 17,
                Name = "Hamada Eldod"
            };

            context.Students.Add(student1);
            context.Students.Add(student2);
            context.Students.Add(student3);
            context.Students.Add(student4);

            context.SaveChanges();

        }
    }
}
