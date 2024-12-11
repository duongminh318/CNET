using System.ComponentModel.DataAnnotations;

namespace Demo.Domain.ApplicationServices.Categories
{
    public class UpdateCategoryViewModel
    {
        [Required]
        public string CategoryName { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
        public List<Guid> ImageIds { get; set; }
    }
}
