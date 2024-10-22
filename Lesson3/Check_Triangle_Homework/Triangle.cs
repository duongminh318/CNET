using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Triangle_Homework
{
    public class Triangle
    {
        /* static string CheckTriangle(double a, double b, double c)
         {
         //demo
             // Kiểm tra xem ba cạnh a, b, c có tạo thành tam giác hay không
             if (a + b <= c || a + c <= b || b + c <= a)
             {
                 return "Ba cạnh nhập vào không tạo thành tam giác.";
             }
             else
             {
                 // Xác định loại tam giác
                 if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                 {
                     return "Ba cạnh nhập vào tạo thành tam giác vuông.";
                 }
                 else if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a)
                 {
                     return "Ba cạnh nhập vào tạo thành tam giác tù.";
                 }
                 else
                 {
                     return "Ba cạnh nhập vào tạo thành tam giác nhọn.";
                 }
             }
         }


         //run
         public void RunCheckTriangle()
         {
             Console.WriteLine("Nhập độ dài ba cạnh của tam giác:");
             double a, b, c;
             bool validInput = false;

             do
             {
                 Console.Write("Cạnh a: ");
                 if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                 {
                     Console.WriteLine("Vui lòng nhập độ dài là số dương.");
                 }
                 else
                 {
                     validInput = true;
                 }
             } while (!validInput);

             validInput = false;
             do
             {
                 Console.Write("Cạnh b: ");
                 if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                 {
                     Console.WriteLine("Vui lòng nhập độ dài là số dương.");
                 }
                 else
                 {
                     validInput = true;
                 }
             } while (!validInput);

             validInput = false;
             do
             {
                 Console.Write("Cạnh c: ");
                 if (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                 {
                     Console.WriteLine("Vui lòng nhập độ dài là số dương.");
                 }
                 else
                 {
                     validInput = true;
                 }
             } while (!validInput);

             string result = CheckTriangle(a, b, c);
             Console.WriteLine(result);
         }*/

        // Function to check if the given sides form a triangle and determine its type
        static string CheckTriangle(double a, double b, double c)
        {
            // Check if sides a, b, c can form a triangle
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                // If the sum of any two sides is less than or equal to the third side, it's not a triangle
                return "The input sides do not form a triangle.";
            }
            else
            {
                // Determine the type of triangle based on side lengths
                if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    // If satisfies Pythagoras theorem, it's a right triangle
                    return "The input sides form a right triangle.";
                }
                else if (a * a + b * b < c * c || a * a + c * c < b * b || b * b + c * c < a * a)
                {
                    // If sum of squares of two sides is less than square of third, it's an obtuse triangle
                    return "The input sides form an obtuse triangle.";
                }
                else
                {
                    // Otherwise, it's an acute triangle
                    return "The input sides form an acute triangle.";
                }
            }
        }

        // Function to run the triangle checking process, handles user input and output
        public static void RunCheckTriangle()
        {
            // Prompt user to input lengths of sides
            Console.WriteLine("Enter the lengths of three sides of the triangle:");
            double a, b, c;
            bool validInput = false;

            // Input validation loop for side a
            do
            {
                Console.Write("Side a: ");
                if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    // Prompt user to enter a positive length if input is invalid
                    Console.WriteLine("Please enter a positive length.");
                }
                else
                {
                    validInput = true; // Set flag to true to exit loop
                }
            } while (!validInput); // Continue loop until valid input is received

            validInput = false; // Reset flag for next input

            // Input validation loop for side b
            do
            {
                Console.Write("Side b: ");
                if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    // Prompt user to enter a positive length if input is invalid
                    Console.WriteLine("Please enter a positive length.");
                }
                else
                {
                    validInput = true; // Set flag to true to exit loop
                }
            } while (!validInput); // Continue loop until valid input is received

            validInput = false; // Reset flag for next input

            // Input validation loop for side c
            do
            {
                Console.Write("Side c: ");
                if (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    // Prompt user to enter a positive length if input is invalid
                    Console.WriteLine("Please enter a positive length.");
                }
                else
                {
                    validInput = true; // Set flag to true to exit loop
                }
            } while (!validInput); // Continue loop until valid input is received

            // Call CheckTriangle function with user input sides and store the result
            string result = CheckTriangle(a, b, c);

            // Output the result of triangle check to the console
            Console.WriteLine(result);
        }
    }
}
