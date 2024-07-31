using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_Lesson6
{
    public class ProductPrice
    {
        /*
         * Viết một chương trình có sử dung Dictionary để quản lý 
         * hệ thống kho hàng. Chương trình nên cho phép người dùng:
            Thêm sản phẩm mới và giá của sản phẩm.
            Cập nhật giá của một sản phẩm hiện có.
            Xóa một sản phẩm.
            Hiển thị tất cả các sản phẩm và giá của chúng.
            Thoát chương trình.
        */


        public void ProductAndPrice()
        {

            Console.OutputEncoding = Encoding.UTF8;
           /* Console.InputEncoding = Encoding.UTF8;*/
            // Khởi tạo Dictionary để lưu trữ sản phẩm và giá
            Dictionary<string, decimal> inventory = new Dictionary<string, decimal>();
            string command;

            do
            {
                // Hiển thị menu cho người dùng
                Console.WriteLine("\n--- Quản lý hệ thống kho hàng ---");
                Console.WriteLine("1. Thêm sản phẩm mới và giá");
                Console.WriteLine("2. Cập nhật giá sản phẩm");
                Console.WriteLine("3. Xóa sản phẩm");
                Console.WriteLine("4. Hiển thị tất cả sản phẩm và giá");
                Console.WriteLine("5. Thoát chương trình");
                Console.Write("Chọn một tùy chọn (1-5): ");
                command = Console.ReadLine();

                // Xử lý lựa chọn của người dùng
                switch (command)
                {
                    case "1":
                        // Gọi phương thức để thêm sản phẩm mới
                        AddProduct(inventory);
                        break;
                    case "2":
                        // Gọi phương thức để cập nhật giá sản phẩm
                        UpdateProductPrice(inventory);
                        break;
                    case "3":
                        // Gọi phương thức để xóa sản phẩm
                        RemoveProduct(inventory);
                        break;
                    case "4":
                        // Gọi phương thức để hiển thị tất cả sản phẩm và giá
                        DisplayProducts(inventory);
                        break;
                    case "5":
                        // Thoát chương trình
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        // Thông báo lỗi khi lựa chọn không hợp lệ
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
            } while (command != "5"); // Lặp lại cho đến khi người dùng chọn thoát
                    // khác 5 thì cứ lặp lại
        }

        static void AddProduct(Dictionary<string, decimal> inventory)
        {
            Console.Write("Nhập tên sản phẩm: ");
            string productName = Console.ReadLine();

            Console.Write("Nhập giá sản phẩm: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                // Kiểm tra nếu sản phẩm đã tồn tại trong kho
                if (inventory.ContainsKey(productName))
                {
                    Console.WriteLine("Sản phẩm đã tồn tại. Vui lòng cập nhật giá thay vì thêm mới.");
                }
                else
                {
                    // Thêm sản phẩm mới vào Dictionary
                    inventory[productName] = price;
                    Console.WriteLine("Sản phẩm đã được thêm.");
                }
            }
            else
            {
                // Thông báo lỗi nếu giá không hợp lệ
                Console.WriteLine("Giá sản phẩm không hợp lệ.");
            }
        }

        // Phương thức để cập nhật giá sản phẩm
        static void UpdateProductPrice(Dictionary<string, decimal> inventory)
        {
            Console.Write("Nhập tên sản phẩm cần cập nhật: ");
            string productName = Console.ReadLine();

            if (inventory.ContainsKey(productName))
            {
                Console.Write("Nhập giá mới cho sản phẩm: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal newPrice))
                {
                    // Cập nhật giá của sản phẩm trong Dictionary
                    inventory[productName] = newPrice;
                    Console.WriteLine("Giá sản phẩm đã được cập nhật.");
                }
                else
                {
                    // Thông báo lỗi nếu giá mới không hợp lệ
                    Console.WriteLine("Giá mới không hợp lệ.");
                }
            }
            else
            {
                // Thông báo lỗi nếu sản phẩm không tồn tại
                Console.WriteLine("Sản phẩm không tồn tại trong kho.");
            }
        }

        // Phương thức để xóa sản phẩm khỏi kho
        static void RemoveProduct(Dictionary<string, decimal> inventory)
        {
            Console.Write("Nhập tên sản phẩm cần xóa: ");
            string productName = Console.ReadLine();

            if (inventory.Remove(productName)) // true nều xoá ok
            {
                // Thông báo thành công nếu sản phẩm được xóa
                Console.WriteLine("Sản phẩm đã được xóa.");
            }
            else
            {
                // Thông báo lỗi nếu sản phẩm không tồn tại
                Console.WriteLine("Sản phẩm không tồn tại trong kho.");
            }
        }

        // Phương thức để hiển thị tất cả sản phẩm và giá của chúng
        static void DisplayProducts(Dictionary<string, decimal> inventory)
        {
            Console.WriteLine("\nDanh sách sản phẩm và giá:");
            foreach (var item in inventory)
            {
                // Hiển thị từng sản phẩm và giá của nó
                Console.WriteLine($"Sản phẩm: {item.Key}, Giá: {item.Value:C}");
            }
        }
    }
}
