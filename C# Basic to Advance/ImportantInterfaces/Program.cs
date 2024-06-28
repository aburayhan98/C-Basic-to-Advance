// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

IEnumerable<string> x;  //Iterate multiple item
ICollection y; //ICollection is implemented IEnumerable

IList<string> a; //List of Interface, IList is implement ICollection

IDisposable c; //dispose internal child element

ICloneable<string> c2; //copy 

/*
 * coupling - altogether
 * decoupling - seperate
 * If access modifier is public, its good to use interface
 * we cannot seperate parent, child class if we use inheritance
 * No need to use inheritance if we reuse the code
  
 * using abstract when coding
 
 * we are applying Enumerator by using  Get Enumerator() method 
 * here, we can get current item where it can move next() and reset() option
 * we can use IEnumerable when use foreach in any class
 * when i apply ICollection, IEnumerable will apply automaticly(see go to defination) 
 * 
 */