using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    internal struct Person
    {
       private readonly int _id ;
        public string Name { get;set; }
        public int Age { get;set; }

        public Person(int id)
        {
            _id = id;
        }
        public void Talk(string message)
        {
            Console.WriteLine(message);

        }

    }
}

/*
 * Structure doesn't  inheritance
 * Interface Supported
 * cannot use virtual,files,abstract etc 
 * always have default constructor
 * 
 */

/* Difference between class and structure
 * structure- value type --- Allocate memory from stack
 * class-reference type ---allocation in heap(heap for bigger size)
 */