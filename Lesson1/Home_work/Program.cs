using System;
using System.Text;

/*
 * 1. Viết chương trình cho phép người dung nhập các thông tin sau:
        Tên, tuổi,địa chỉ, giới tính
    2. In ra ngoài màn hình các thông tin đó sử dung template string
 */

namespace UserInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Khai báo biến để lưu thông tin người dùng
            string name;
            int age;
            string address;
            string gender;
            /**/
            // Nhập thông tin người dùng
            Console.Write("Nhập tên: ");
            name = Console.ReadLine();

            Console.Write("Nhập tuổi: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Nhập địa chỉ: ");
            address = Console.ReadLine();

            Console.Write("Nhập giới tính (Nam/Nữ/Khác): ");
            gender = Console.ReadLine();

            // Sử dụng template string để in thông tin ra màn hình
            string userInfo = $"Thông tin người dùng:\n" +
                              $"Tên: {name}\n" +
                              $"Tuổi: {age}\n" +
                              $"Địa chỉ: {address}\n" +
                              $"Giới tính: {gender}";

            Console.WriteLine(userInfo);
        }
    }
}
