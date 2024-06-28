using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public static class Counter //if we use static,we must declare static in every step
    {
        private static int counter; 

         static Counter() 
        {
            counter = 0;
        }
        public static void Increament()
        {
            counter++;
        }
    }
}
/*
 * static must have to use inside of the  class name 
 * if class is not static, we cannot use static inside of classes
 * it depends only classes,not in instance
 * we cannot use finaliizer 
 * can be use in constructor
 */