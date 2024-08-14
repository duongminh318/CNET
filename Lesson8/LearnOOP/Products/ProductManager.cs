using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP.Products
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
                Console.WriteLine($"Choose the option: {Environment.NewLine} 1.Add {Environment.NewLine} 2.Update {Environment.NewLine} 3.Display {Environment.NewLine} 4.Delete {Environment.NewLine} 5.Search");
                var option = ValidateInt("option", s => s <= 5 && s >= 1);
                switch (option)
                {
                    case 1:
                        HandleAddProduct();
                        break;
                    case 2:
                        HandleUpdateProduct();
                        break;
                    case 3:
                        HandleDisplayProducts();
                        break;
                    case 4:
                        HandleDeleteProducts();
                        break;
                    case 5:
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
            var product = new Product();
            Console.WriteLine("Input the product Id");
            product.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the product name");
            product.Name = Console.ReadLine();

            product.Price = ValidateDecimal("product price", s => s > 0);

            product.Inventory = ValidateInt("product inventory", s => s > 0);

            Console.WriteLine("Input the product detail");
            product.Detail = Console.ReadLine();

            productService.Add(product);

            Console.WriteLine("Add product successfully!");
        }

        private void HandleUpdateProduct()
        {
            try
            {
                var product = new UpdateProductViewModel();
                Console.WriteLine("Input the product Id");
                product.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Input the product name");
                product.Name = Console.ReadLine();

                product.Price = ValidateDecimal("product price", s => s > 0);

                product.Inventory = ValidateInt("product inventory", s => s > 0);

                Console.WriteLine("Input the product detail");
                product.Detail = Console.ReadLine();

                productService.Update(product);

                Console.WriteLine("update product successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void HandleDisplayProducts()
		{
            PrintProduct(productService.GetProducts);
        }

		private void HandleDeleteProducts()
		{
			try
			{
				Console.WriteLine("Input the product Id");
				var id = int.Parse(Console.ReadLine());
				productService.Delete(id);
                Console.WriteLine("Delete product successfully!");
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}
		private void HandleSearchProducts()
		{
            Console.WriteLine("Input the keyword");
            var results = productService.Search(Console.ReadLine());
            PrintProduct(results);
        }

		private void PrintProduct(List<Product> products)
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
