using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore.Models
{
    public class VariantDetailViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public EntityStatus Status { get; set; }
        public string StatusLabel => Status.ToString();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public Guid ProductId { get; set; }

    }

}
