
using ClassExamples;

Product product = new Product();
product.name = "Camera Nikon";
product.price = 100;

Console.WriteLine(product.price);

string name = product.GetUrlFriendlyName('_');
Console.WriteLine(name);

Counter.Increament(); //for static method,no need to create instance 