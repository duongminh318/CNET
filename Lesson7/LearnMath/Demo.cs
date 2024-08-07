using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMath
{
    public class Demo
    {
        public void MathMethods()
        {
            Console.WriteLine("mời thím nhập vào 1 số");
            var num= double.Parse(Console.ReadLine());
            //Console.WriteLine(num);

            //giá trị tuyệt đối
            Console.WriteLine($"Abs của {num} là: "+Math.Abs(num));

            // căn bặc 2
            Console.WriteLine($"Sqrt của {num} là: " + Math.Sqrt(num));

            //Mũ
            Console.WriteLine($"Pow của {num} ^3 là: " + Math.Pow(num, 3));
            //Max , Min
            Console.WriteLine($"Max của {num} và 8 là: " + Math.Max(num, 8));
            Console.WriteLine($"Min của {num} và 8 là: " + Math.Min(num, 8));
            //Pi, e
            Console.WriteLine(""+Math.PI);//3.14...
            Console.WriteLine(""+Math.E);//2,7...

            //một số hàm lượng giác

        }
    }
}
