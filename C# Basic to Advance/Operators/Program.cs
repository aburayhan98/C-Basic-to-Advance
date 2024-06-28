int x = 22;
 int y = 23;
int z= x + y;

int a = x / y;
int b = x % y;

Console.WriteLine(++x);
Console.WriteLine(x);

a *= 2;
b /= 3;
a += 10;
b -= 5;

if (x > 4)
{
    Console.WriteLine("X is greater than 4");

}
else if (x >= 0) { Console.WriteLine("X is between 0 and 4"); }

else
    Console.WriteLine(" X is less than or equal to 4");

bool statement = x > 5 && y < 10; //And
if (statement)
{
    Console.WriteLine("Success");
}
if(x> 4 || y < 10)  //Or
{
    Console.WriteLine("Success");
}

bool check = x != y;


y = y >> 1; // Right Shift
Console.WriteLine("Y after right shift" + y);

uint t = 5;
t = ~t;
Console.WriteLine(t);

int a1 = 5;
int b1 = 12;
int c1 = a1 ^ b1;  //bitwise XOR


int c2 = a1 | b1;

int c3 = a1 & b1;
Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);

string name = Console.ReadLine();

name= name.Length > 10 ? name.Substring(0, 10) : name;  ///ternary conditional operator
Console.WriteLine(name);





