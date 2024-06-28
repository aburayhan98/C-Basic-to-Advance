using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramWorkExample
{
    public class Student
    {
        public int Id { get; set; } //by convention
        public string Name { get; set; }
        public double CGPA { get; set; }
        public virtual List<CourseStudent> StudentCourses { get; set; }
    }
}
