using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramWorkExample
{
    public class CourseStudent  //combination of primary key in two table(pivort table)
    {
        //foreign key
        public int StudentId { get; set; }  
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
