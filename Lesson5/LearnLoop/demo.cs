using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoop
{
    public class Demo
    {
        public void PrintOddNumbers(int limit)
        {
            for (int i = 0; i <= limit; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);

            }
        }

        //Nhập số lượng sv
        public void InputStudent()
        {
            // Nhập số lượng sinh viên
            Console.Write("Enter the number of students: ");
            var numberOfStudents = int.Parse(Console.ReadLine());

            // Khai báo mảng để lưu thông tin sinh viên
            string[] names = new string[numberOfStudents];
            int[] ages = new int[numberOfStudents];
            string[] addresses = new string[numberOfStudents];

            // Gọi hàm để nhập thông tin sinh viên
            EnterStudentInfo(names, ages, addresses);

            // Hiển thị thông tin sinh viên đã nhập
            Console.WriteLine("\n Infor Students Inputed:");
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"Tên: {names[i]}, Tuổi: {ages[i]}, Địa chỉ: {addresses[i]}");
            }
        }

        //// Hàm nhập thông tin sinh viên
        static void EnterStudentInfo(string[] names, int[] ages, string[] addresses)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Nhập thông tin cho sinh viên thứ {i + 1}:");

                // Nhập tên sinh viên
                Console.Write("Tên: ");
                names[i] = Console.ReadLine();

                // Nhập tuổi sinh viên
                Console.Write("Tuổi: ");
                ages[i] = int.Parse(Console.ReadLine());

                // Nhập địa chỉ sinh viên
                Console.Write("Địa chỉ: ");
                addresses[i] = Console.ReadLine();
            }
        }




    }
}
