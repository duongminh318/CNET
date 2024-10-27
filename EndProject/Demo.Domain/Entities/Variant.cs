using System.ComponentModel.DataAnnotations.Schema;
using Demo.Domain.Enums;

namespace Demo.Domain.Entities
{

    [Table("Variants")]
    public class Variant : DomainEntity<Guid>, IAuditTable
    {
        [Column(TypeName = "nvarchar(1000)")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountPrice { get; set; }
        public int Quantity { get; set; } = 0;
        public string? ImageJson { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public EntityStatus Status { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
