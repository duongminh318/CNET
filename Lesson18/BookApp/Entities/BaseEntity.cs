using System.ComponentModel.DataAnnotations;

namespace Ex1GenericRepositoryUOW.Entities
{
    public class BaseEntity <TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
