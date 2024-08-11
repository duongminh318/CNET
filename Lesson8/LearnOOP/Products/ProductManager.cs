using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP.Products
{
	public class ProductManager
	{
		private ProductService productService = new ProductService();
		public void Init()
		{
			Console.WriteLine($"Choose the option: {Environment.NewLine} " +
				$"1.Add {Environment.NewLine} 2.Update {Environment.NewLine} " +
				$"3.Display {Environment.NewLine} 4.Delete");
			if (int.TryParse(Console.ReadLine(), out int option))
			{
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
					default:
						break;
				}
			}

		}

		private void HandleAddProduct()
		{
			var product = new Product();
			Console.WriteLine("Input the product Id");
			product.Id = int.Parse(Console.ReadLine());

			Console.WriteLine("Input the product name");
			product.Name = Console.ReadLine();


			Console.WriteLine("Input the product price");
			product.Price = decimal.Parse(Console.ReadLine());


			Console.WriteLine("Input the product inventory");
			product.Inventory = int.Parse(Console.ReadLine());

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


				Console.WriteLine("Input the product price");
				product.Price = decimal.Parse(Console.ReadLine());


				Console.WriteLine("Input the product inventory");
				product.Inventory = int.Parse(Console.ReadLine());

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
			foreach (var item in productService.GetProducts)
			{
				Console.WriteLine($"id: {item.Id} - name: {item.Name}...");
			}
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
	}
}
