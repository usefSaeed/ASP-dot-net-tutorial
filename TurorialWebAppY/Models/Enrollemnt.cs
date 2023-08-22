using System.Collections.Generic;

namespace TutorialWebAppY.Models
{
    public class Enrollment
    {
        public Course EnrolledCourse { get; set; }

        public List<Student> Students { get; set; }
    }
}
