using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    public class Product
    {
        //public,private,protected,internal are access modifier

        //Field
        public int id;
        public string name;
        public const string barcode = "8723487429"; //it will use only for declaration.This value cannot not change
        public double price;

        public string Name { get; set; } // Auto property

        public Product(string name, double price)  //Parameterize Constructor (must have a value in instance)
        {                                           //constructor overloading have no return type but different parameter
            id = 0;
            this.name = name;
            this.price = price;


        }
        public Product() :this(String.Empty,0) //constructor chaining (no return type)
        {

        }
         ///use base if we want to override the child class
        ~Product()  //Destructor  it will destroy the unnecessary program & clear the memory,finallizer will release the memory
         {

         }
        /*
         * 
         * Method
         * 
         * 
         */
        public virtual string GetUrlFriendlyName()   /// method overriding must have virtual 
        {                                                  /*if we override the child class*/
            return name.ToLower().Replace(' ', '_');
        }
        public string GetUrlFriendlyName(char c)
        {
            return name.ToLower().Replace(' ', c);
        }
        public double GetRoundedPrice()  //method
        {
            return Math.Round(price);
        }

        public double Test(int a, string b)  //method overloading, same name differnet parameter
        {
            throw new NotImplementedException();
        }
        public double Test(string a, int b)
        {
            throw new NotImplementedException();
        }

    }

}
