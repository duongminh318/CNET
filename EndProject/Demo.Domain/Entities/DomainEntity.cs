using System.ComponentModel.DataAnnotations;

namespace Demo.Domain.Entities
{
    public abstract class DomainEntity <TKey>
    {
        [Key]
        public TKey Id { get; set; }
       
    }
}
