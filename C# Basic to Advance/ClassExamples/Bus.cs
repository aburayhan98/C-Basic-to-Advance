using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public class Bus : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Starting Bus");
        }

        public override void Stop()
        {
            Console.WriteLine("Stoping Bus");
        }
    }
}
//override the abstract class