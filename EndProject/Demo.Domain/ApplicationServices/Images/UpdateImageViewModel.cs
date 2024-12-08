using System.ComponentModel.DataAnnotations;



namespace Demo.Domain.ApplicationServices.Images
{
    public class UpdateImageViewModel
    {
        [Required]
        public Guid ImageId { get; set; }

        [Required]
        public string ImageName { get; set; }
    }
}

