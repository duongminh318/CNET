using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ex1GenericRepositoryUOW.Entities;

namespace Ex1RepositoryUOW.Entities
{
    [Table("Books")]
    public class Book : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }
    }
}
