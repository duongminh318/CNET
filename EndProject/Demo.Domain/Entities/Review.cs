using System.ComponentModel.DataAnnotations.Schema;
using Demo.Domain.Enums;

namespace Demo.Domain.Entities
{
    [Table("Reviews")]
    public class Review : DomainEntity<Guid>, IAuditTable
    {

        [Column(TypeName = "nvarchar(1000)")]
        public string ReviewerName { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string? Email { get; set; }

        [Column(TypeName = "ntext")]
        public string? Content { get; set; }
        public int Rating { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public EntityStatus Status { get; set; }

    }
}

