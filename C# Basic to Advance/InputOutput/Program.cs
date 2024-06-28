// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Hello");
Console.Write("World");
Console.WriteLine();

string s = Console.ReadLine();

string[] inputsParts = s.Split(',');
Console.WriteLine($"Name: {inputsParts[0]},Age:{inputsParts[1]},CGPA: {inputsParts[2]}");

//if-else statement
if (s == "orange")
{
    Console.WriteLine("Fruits");
}
else if (s == "Toyota")
{
    Console.WriteLine("Car");
}
 else
{
    Console.WriteLine("Nothing");
}
//switch case statement

 switch(s)
 {
    case "orange":
            Console.WriteLine("Fruits");
        break;
    case "Toyota":
        Console.WriteLine("Car");
        break;
    default:
        Console.WriteLine("Nothing");
        break;

 }
