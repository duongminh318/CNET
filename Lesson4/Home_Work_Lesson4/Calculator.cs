using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Home_Work_Lesson4
{
    public class Calculator
    {

        /*
         * EX1
         * Viết chương trình C# để thực hiện một phép toán đơn giản
         * (cộng, trừ, nhân, chia) dựa trên sự chọn lựa của người dùng 
         * (viết trong hàm và gọi hàm trong Program.cs)
         */

        // hàm thực hiện chương trình máy tính
        #region EX 1
        public void RunCalculator()
        {
            //lựa chọn phép toán
            Console.WriteLine("-----Welcome to the Simple Calculator -----");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.Write("Enter your choice (1/2/3/4): ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                return;
            }

            // nhập liệu 2 số
            Console.WriteLine("Enter the first number: ");
            string inputNum1 = Console.ReadLine();
            double num1;
            if (!double.TryParse(inputNum1, out num1))
            {
                Console.WriteLine("Invalid input for the first number. Please restart the program and enter a valid number.");
                return;
            }

            Console.WriteLine("Enter the first number: ");
            string inputNum2 = Console.ReadLine();
            double num2;
            if (!double.TryParse(inputNum2, out num2))
            {
                Console.WriteLine("Invalid input for the second number. Please restart the program and enter a valid number.");
                return;

            }
            double result;
            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine($"Result: {num1} +{num2}= {result}");
                    break;

                case 2:
                    result = Subtract(num1, num2);
                    Console.WriteLine($"Result: {num1} +{num2}= {result}");
                    break;

                case 3:
                    result = Multiply(num1, num2);
                    Console.WriteLine($"Result: {num1} +{num2}= {result}");
                    break;
                case 4:
                    if (num2 != 0) //khác không tính toán bình thường
                    {
                        result = Divide(num1, num2);
                        Console.WriteLine($"Result: {num1} +{num2}= {result}");
                    }
                    else
                    {
                        //xuất ra lỗi mặc định
                        Console.WriteLine(new DivideByZeroException());
                    }
                    break;
            }
        }

        // các hàm tính toán
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            // nếu b(mẫu)=0 ném ra 1 thông báo lỗi
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed");
            }
            return a / b;
        }
        #endregion


        /*EX2
         * Viết chương trình nhập vào hai số, thực hiện phép chia 
         * số thứ 1 cho số thứ 2,
         * sử dụng try catch để bắt exception trong trường hợp số 
         * thứ 2 nhập  = 0.
         */
        #region EX2
        public void RunDivision()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                // Nhập số thứ nhất
                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());

                // Nhập số thứ hai
                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                // Thực hiện phép chia và in kết quả
                double result = Divide2(num1, num2);
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            }
            catch (DivideByZeroException) // chia 0
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException) // định dạng sai
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers.");
            }
            catch (Exception ex) //sự cố chung
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        public double Divide2(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
        #endregion


    }
}
