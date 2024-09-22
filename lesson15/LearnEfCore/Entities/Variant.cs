using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore.Entities
{
    [Table("Variants")]
    public class Variant : BaseEntity<Guid>
    {
        [Column(TypeName = "nvarchar(1000)")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountPrice { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public Guid ProductId { get; set; }

    }
}
