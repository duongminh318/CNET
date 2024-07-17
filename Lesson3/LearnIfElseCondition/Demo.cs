using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnIfElseCondition
{
    public class Demo
    {
        public string GetLearningGetLearningResult(double score)
        {
            if (score < 5)
            {
                return "weak";
            }
            else if (score == 5)
            {
                return "avg";
            }
            else
            {
                return "quite good";
            }

        }

        // nhập điểm
        /* public void RunGetLearningResult()
         {

             Console.WriteLine("Input the score");

             try
             {
                 double score = double.Parse(Console.ReadLine());
                 if (score >= 0 && score <= 10)
                 {
                     var result = GetLearningGetLearningResult(score);
                     Console.WriteLine($"The result: {result}");
                 }
                 else
                 {
                     Console.WriteLine("score ranges from 0 to 10");
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
                 Console.WriteLine("something went wrong");
             }

         }*/


        //cách khác
        /*     public void RunGetLearningResult()
             {

                 Console.WriteLine("Input the score");

                 if(double.TryParse(Console.ReadLine(), out double score))

             }*/



        /*
         * Exercise 1
        1.Viết chương trình C# để kiểm tra xem một số nguyên nhập từ người dùng là số chẵn hay lẻ.
        2.Viết chương trình C# để tìm số lớn nhất trong ba số nhập từ người dùng.
        Exercise 2
        1. Viết chương trình kiểm tra 1 năm có phải năm nhuận hay 
        không, biết rằng 1 năm nếu là năm nhuận thì vừa chia hết
        cho 100 vừa chia hết cho 400 hoặc vừa không chia hết cho
        100 và vừa chia hết cho 4 
         */


        // Even || Odd
        public string IsEvenOrOdd(double number)
        {
            if (number % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
        public void RunIsEvenOrOdd()
        {
            Console.WriteLine("Input the number:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                var result = IsEvenOrOdd(number);
                Console.WriteLine($"The number is: {result}");
            }
            else
            {
                Console.WriteLine("Input is not a valid number.");
            }
        }


        // max of 3 numbers
        public double FindMax(double a, double b, double c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if (b >= a && b >= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public void RunFindMax()
        {
            try
            {
                Console.WriteLine("Input the first number:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Input the second number:");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Input the third number:");
                double num3 = double.Parse(Console.ReadLine());

                var maxNumber = FindMax(num1, num2, num3);
                Console.WriteLine($"The largest number is: {maxNumber}");
            }
            catch (Exception)
            {
                Console.WriteLine("One or more inputs are not correct numbers.");
                return;
            }
        }

        /*Viết chương trình kiểm tra 1 năm có phải năm nhuận hay không,
         * biết rằng 1 năm nếu là năm nhuận thì vừa chia hết cho 100 vừa chia 
         * hết cho 400
         * hoặc vừa không chia hết cho 100 và vừa chia hết cho 4*/

        //Check Leap Year (2020, 2000, 2012... => true)
        public bool CheckLeapYear(int year)
        {
            if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                return true;
            }


            return false;

        }

        public void RunCheckLeapYear()
        {
            Console.WriteLine("Input the year:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int year) && year > 0)
            {

                //cách 1 if-else
                /*
                  var isLeap = CheckLeapYear(year);
                 if (isLeap)
                 {
                     Console.WriteLine($"{year} is a leap year.");
                 }
                 else
                 {
                     Console.WriteLine($"{year} is not a leap year.");
                 }*/
                //cách 2 toán tử 3 ngôi
                string result = CheckLeapYear(year) ? $"{year} is leap year" : $"{year} is not leap year";
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("Input is not a valid year.");
            }
        }


    }
}
