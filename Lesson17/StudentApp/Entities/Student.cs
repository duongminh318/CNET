using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApp.Entities
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
    }
}
