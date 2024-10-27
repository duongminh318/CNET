using System.ComponentModel.DataAnnotations.Schema;
using Demo.Domain.Enums;

namespace Demo.Domain.Entities
{
    [Table("OrderDetails")]
    public class OrderDetail : DomainEntity<Guid>, IAuditTable
    {
        public Guid UserId { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string VariantName { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PurchasePrice { get; set; }

        public int Quantity { get; set; }

        public Guid VariantId { get; set; }

        public Guid OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; }

        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public EntityStatus Status { get; set; }

    }
}
