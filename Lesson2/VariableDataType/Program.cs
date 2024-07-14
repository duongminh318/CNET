using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Input the Name");

string name=Console.ReadLine();
Console.WriteLine("tên của thím là: "+name);

Console.WriteLine("Input the age");

int age =int.Parse( Console.ReadLine());
Console.WriteLine("tuổi của thím là: " + age);

Console.WriteLine("Input the address");

string address = Console.ReadLine();
Console.WriteLine("Địa chỉ của thím là: " + address);

Console.ReadKey();
