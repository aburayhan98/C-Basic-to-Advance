// See https://aka.ms/new-console-template for more information

using ParaMeterModifier;
TestClass  testclass = new TestClass();
int r = testclass.Sum("hello", 2, 3, 9, 8 );
Console.WriteLine(r);

int[] items = new int[] { 3, 5, 76, 4, 8, 10 };
int r2 = testclass.Sum("World", items);
Console.WriteLine(r2);