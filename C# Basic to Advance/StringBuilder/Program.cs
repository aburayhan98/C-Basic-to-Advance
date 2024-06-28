
using System.Text;

StringBuilder builder = new StringBuilder();
builder.Append("Hello World")
    .AppendLine()
    .Replace('l','m');

string text = builder.ToString();
Console.WriteLine(text);

for(int i = 0; i < text.Length; i++)
{
    builder[i] = 'c';
}
Console.WriteLine(builder);

/*
 * StringBuilder itself a class
 * set the value in previous reference
 * instead of builder we use method chaining
 * stringbuild has raad and write capabitily
 * we can build the character also
 * The return type from the method must be assigned to the same object  
 */