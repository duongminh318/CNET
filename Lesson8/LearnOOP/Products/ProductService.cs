using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP.Products
{
	public class ProductService
	{
		private List<Product> products = new List<Product>();

		public void Add(Product product)
		{
			products.Add(product);
		}
		public void Update(UpdateProductViewModel model)
		{
			var product = GetProduct(model.Id);
			product.Name = model.Name;
			product.Price = model.Price;
			product.Inventory = model.Inventory;
			product.Detail = model.Detail;
		}

		public void Delete(int id)
		{
			var product = GetProduct(id);
			products.Remove(product);
		}

		public List<Product> Search(string key)
		{
			var result = new List<Product>();
			var check = int.TryParse(key, out int id);
			if (check)
			{
				Func<Product, bool> condition = s =>
				s.Id == id || s.Name.Contains(key, StringComparison.OrdinalIgnoreCase);

				result = products.Where(condition).ToList();
			}
			else
			{
				result = products.Where(s => s.Name.Contains(key, StringComparison.OrdinalIgnoreCase)).ToList();
			}
			return result;
		}

		public List<Product> GetProducts => products;

		private Product GetProduct(int id)
		{
			var product = products.FirstOrDefault(x => x.Id == id);
			if (product == null)
			{
				throw new Exception($"product with id: {id} is not found");
			}
			return product;
		}
	}
}

