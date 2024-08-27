using LearnGeneric.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGeneric.Products
{
    public class Product: BaseEntity<int>
    {
    /*	public int Id { get; set; }*/
        public string Name { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }

    }
}
