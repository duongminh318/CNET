using System.ComponentModel.DataAnnotations.Schema;
using Ex1RepositoryUOW.Entities;

namespace Ex1GenericRepositoryUOW.Entities
{
    [Table("Authors")]
    public class Author : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
