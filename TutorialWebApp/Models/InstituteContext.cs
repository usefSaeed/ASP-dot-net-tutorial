using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TutorialWebApp.Models
{
    public class InstituteContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
