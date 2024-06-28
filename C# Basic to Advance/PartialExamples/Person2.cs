using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialExamples
{
    public partial class Person  //we cannot inherite another class here because person base must 
    {
        public string Address { get; set; }

        public void Walk()
        {
            Console.WriteLine("Walking");
        }
    }
}

/*
 * partial class is use for part by part separation 
 * avoiding auto generated problem
 * benefit for windows form application
 * easily inheritate 
 * note: no multiple instance in classes, it will inaccessible for program file and build faild
 * 
 */
