using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExamples
{
    public partial class Person : User
    {
        public string Name { get; set; }
        public void Talk(string text)
        {
            Console.WriteLine(text);
        }

    }
}
