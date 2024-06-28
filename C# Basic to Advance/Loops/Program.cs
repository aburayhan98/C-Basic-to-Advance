
for(int i =0; i < 10; i++)
{
    Console.WriteLine("Hello");
}

int x = 100;
while(x > 0)
{
    x /= 10;
    Console.WriteLine("Dividing");
}

x = 100;

do
{
    x /= 10;
    Console.WriteLine("Dividing");
}
while(x > 0);


int[] ages = { 3, 4, 0, 9 , -5};

for(int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}

foreach(int age in ages)
{
    if (age < 0)
        break;
    if (age == 0)
        continue;
    Console.WriteLine(age);
}