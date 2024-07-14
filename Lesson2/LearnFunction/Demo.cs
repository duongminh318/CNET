using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LearnFunction
{
    public class Demo
    {
        public double CalRec(double width, double length)
        {
            double area= width* length;
            return area;
        }


        public void RunCalRec()
        {
            Console.WriteLine("Input the width");
            double.TryParse(Console.ReadLine(), out double width);

            Console.WriteLine("Input the leght");
           

            try
            {
                double.TryParse(Console.ReadLine(), out double leght);

                var result = CalRec(width, leght);
                Console.WriteLine($"diện tích là HCN có chiều rộng {width} và chiều dài {leght} là : {result}");
            } catch (Exception ex)
            {
                Console.WriteLine("Leght is not correct");
            }
        }

        //viết hàm tính diện tích hình tròn
        // viết hàm run tính dt hình tròn


        public double CalCircle(double rad, out double perimeter)
        {
            double area= Math.PI*rad*rad;   //pi*(R bình)
            perimeter = rad * 2 * Math.PI;
            return area;

        }

        public void RunCalCircle()
        {
            Console.WriteLine("Input the radius of the circle");
            // nếu đổi được thì rad= số, tryParse= true
            // nếu ko đổi ra số dc tryParse=fasle ,  rad=0
           double.TryParse(Console.ReadLine(), out double rad); // kiểu ném ra giống try catch

            // nhận out ném ra
            /* var result = CalCircle(rad, out double perimeter);
             Console.WriteLine($"diện tích của Tròn có bán kính  {rad} là : {result} và chu vi : {perimeter}");*/

            //không nhận out ném ra
            var result = CalCircle(rad, out double _);
            Console.WriteLine($"diện tích của Tròn có bán kính  {rad} là : {result} ");
        }

        // thay đổi giá trị 
        public void ChangeValue(int number)
        {
            number += 5;

        }

        public void ChangeValue(ref int number)
        {
            number += 5;

        }

    }
}
