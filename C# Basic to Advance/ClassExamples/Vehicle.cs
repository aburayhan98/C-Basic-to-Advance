using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public abstract class Vehicle
    {
        public abstract void Start();
        public abstract void Stop();

        public void Something()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}


/*
 * abstract method can be use only for abstract class
 * when we hide something
 * use for incompleteness, it will complete in child class
 * make instance in child class
 * For Reason, override can be use in child class so that it can be implement
 */