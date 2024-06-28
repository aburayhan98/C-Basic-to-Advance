using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    public class Coordinate <T,Q> //generic parameter with class
        where T : class , new() //constrain
        where Q : struct       //constrain
    {
        
        public T X {  get; set; } 
        public Q Y { get; set; }

        public void Add<K>(K val) where K : class, new() //generic method
        {
            T t;
            Q q;
            K k;

        }
    }
    
}
/*
 * Generics is basically use for change data type by using same code
 * it can added only for class and method
 * we can declare custom type
 * we can can the datatype independent so that we can reuse this code
 * <-accessibility->
 * Generic method element can access only his method
 * generic class can access anywhere
 * 
 * we can set class,interface but we cannot set premitive type 
 *  we can use generic parameter in method also
 *  *constrain* -> to make limitation in parameter, we can use constain
 *  
 *  we can any structure but we cannot use string 
 *  we can use everrything in classes
 *  Inherite possible
 *  we cannot access if its sealed
 */