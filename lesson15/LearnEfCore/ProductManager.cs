using LearnEfCore.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore
{
    public class ProductManager
    {
        private readonly ProductService productService;

        public ProductManager()
        {
            productService = new ProductService();
        }
        public void Init()
        {
            var isContinue = true;

            while (isContinue)
            {
                Console.WriteLine($"Choose the option: " +
                    $"{Environment.NewLine} 1.Add " +
                    $"{Environment.NewLine} 2.Search");
                var option = ValidateInt("option", s => s <= 2 && s >= 1);
                switch (option)
                {
                    case 1:
                        HandleAddProduct();
                        break;
                    case 2:
                        HandleSearchProducts();
                        break;
                    default:
                        break;
                }


                Console.WriteLine("Do you want to continue? y/n");
                isContinue = Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase);

            }
            return;
        }

        private void HandleAddProduct()
        {
            var product = new CreateProductViewModel();

            Console.WriteLine("Input the product name");
            product.Name = Console.ReadLine();

            product.Price = ValidateDecimal("product price", s => s > 0);

            product.Quantity = ValidateInt("product inventory", s => s > 0);

            product.Status = (EntityStatus)
                              ValidateInt("status: 1-active; 2-inactive", s => s >= 1 && s <= 2);

            productService.CreateProduct(product);

            Console.WriteLine("Add product successfully!");
        }

        private void HandleSearchProducts()
        {
            // bài tập vn làm phần search này
            //Console.WriteLine("Input the keyword");
            //var results = productService.GetProducts(Console.ReadLine());
            //PrintProduct(results);
          
        }

        private void PrintProduct(List<ProductViewModel> products)
        {
            if (products != null && products.Any())
            {
                foreach (var item in products)
                {
                    Console.WriteLine($"id: {item.Id} - name: {item.Name}...");
                }
            }
            else
            {
                Console.WriteLine("Cannot find the data");
            }

        }

        private decimal ValidateDecimal(string field, Func<decimal, bool> condition)
        {
            Console.WriteLine($"Input the {field}");
            var check = decimal.TryParse(Console.ReadLine(), out decimal value) && condition(value);
            while (!check)
            {
                Console.WriteLine($"The {field} is not in correct format, re input the {field}");
                check = decimal.TryParse(Console.ReadLine(), out value) && condition(value);
            }
            return value;
        }

        private int ValidateInt(string field, Func<int, bool> condition)
        {
            Console.WriteLine($"Input the {field}");
            var check = int.TryParse(Console.ReadLine(), out int value) && condition(value);
            while (!check)
            {
                Console.WriteLine($"The {field} is not in correct format, re input the {field}");
                check = int.TryParse(Console.ReadLine(), out value) && condition(value);
            }
            return value;
        }
    }
}
