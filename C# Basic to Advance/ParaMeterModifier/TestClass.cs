using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParaMeterModifier
{
    public class TestClass
    {
        public int Sum(string text, params int[] items)
        {
            int sum  =0;
            foreach (var item in items)
            {
                sum += item;
            }
            return sum;
        }
    }
}

/*
 * params can take any size
 * can be sent ot array also
 * string can be use if we set before  the params
 * params always set to the last
 * we can use params at once in the same method
 */