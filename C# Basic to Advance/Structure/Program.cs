

using Structure;

Person p = new Person(3);
p.Name = "jalaluddin";
p.Age = 41;
p.Talk("Hello Everyone");
  
Person p2 = p;  //value type, could not refer
Console.WriteLine(p.Age); //41
Console.WriteLine(p2.Age); //41

p2.Age = 31; //value change that means it will change in p2 but not in p

Console.WriteLine(p.Age); //41
Console.WriteLine(p2.Age); //31

void DoSomething(Person person)
{
    person.Age = 21;
}
DoSomething(p);
Console.WriteLine(p.Age); //41

string x = "Hello";  //string is basically a reference type but if we use in struct it act like value type
string y = x;
x = "Message";

