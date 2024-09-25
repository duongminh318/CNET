using System.ComponentModel.DataAnnotations;

namespace DemoApp.Models
{
    public class CreateStudentViewModel
    {
        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
