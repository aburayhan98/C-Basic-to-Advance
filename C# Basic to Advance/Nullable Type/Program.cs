
int ? x = null;  //hold eighter an integer value or null 

if(true)
{
    x = 0;
}
else
{
    x = 1;
}


if(x.HasValue)
{
    Console.WriteLine(x.Value);
}

string? c = null;

int r = x ?? 5; // if x is null then the value of r is assign to 5 or else assign to x
x ??= 5; // x is null then assign 5 or assign the value of x