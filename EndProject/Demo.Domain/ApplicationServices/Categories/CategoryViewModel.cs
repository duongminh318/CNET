using Demo.Domain.ApplicationServices.Images;
using Demo.Domain.Enums;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Demo.Domain.ApplicationServices.Categories
{
    public class CategoryViewModel
    {
       
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public EntityStatus Status { get; set; }
        public List<ImageViewModel>? Images { get; set; }

        [JsonIgnore]
        public  string ImageJson { get; set; }
    }

    
}
