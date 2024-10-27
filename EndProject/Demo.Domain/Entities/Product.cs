using System.ComponentModel.DataAnnotations.Schema;
using Demo.Domain.Enums;

namespace Demo.Domain.Entities
{
    [Table("Products")]
    public class Product : DomainEntity<Guid>, IAuditTable
    {
        [Column(TypeName = "nvarchar(1000)")]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string? Detail { get; set; }

        [Column(TypeName = "ntext")]
        public string? Description { get; set; }

        public string? ImageJson { get; set; }

        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<Variant> Variants { get; set; }

        

        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public EntityStatus Status { get; set; }

    }
}
