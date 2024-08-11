using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, Price: {Price:C}, Quantity: {Inventory}";
        }


        public class ProductManager
        {
           
        }


    }
}
