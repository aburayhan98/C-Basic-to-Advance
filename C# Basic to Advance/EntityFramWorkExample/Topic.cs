using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramWorkExample
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CourseId { get; set; }
        public virtual Course TopicCourse { get; set; }
    }
}
