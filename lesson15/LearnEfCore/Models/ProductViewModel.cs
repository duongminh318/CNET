using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public EntityStatus Status { get; set; }
        public string StatusLabel => Status.ToString();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
