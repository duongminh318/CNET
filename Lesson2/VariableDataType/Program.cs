using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Input the Name");
string name=Console.ReadLine();


Console.WriteLine("Input the age");
int age =int.Parse( Console.ReadLine());


Console.WriteLine("Input the address");
string address = Console.ReadLine();

Console.WriteLine($"your name: { name}, your age: { age}, your address: { address}");


Console.ReadKey();
