using System.ComponentModel.DataAnnotations;

namespace Demo.Domain.ApplicationServices.Categories
{
    public class CreateCategoryViewModel
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
