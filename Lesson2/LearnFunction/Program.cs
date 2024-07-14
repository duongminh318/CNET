// See https://aka.ms/new-console-template for more information
using LearnFunction;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.InputEncoding = Encoding.UTF8;

//Console.WriteLine("Chương Trình Tính Diện Tích HCN!");
Demo demo= new Demo();
double result = demo.CalRec(3, 5);

//Demo demo1= new Demo();
//demo1.RunCalRec();

//Demo demo2= new Demo();
//demo2.RunCalCircle();
int number = 10;
demo.ChangeValue(number);   //ko làm thay giá trị tham sô ban đầu - tham trị
demo.ChangeValue(ref number);   // làm thay giá trị tham sô ban đầu - tham chiếu

Console.ReadLine();


