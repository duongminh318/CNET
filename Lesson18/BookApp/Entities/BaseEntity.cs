using System.ComponentModel.DataAnnotations;

namespace Ex1GenericRepositoryUOW.Entities
{
    public abstract class BaseEntity <TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
