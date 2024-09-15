using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore.Entities
{
    [Table("Products")]
    public class Product : BaseEntity<Guid>
    {
        [Column(TypeName = "nvarchar(1000)")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
