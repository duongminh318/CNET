using LearnEfCore.Entities;
using LearnEfCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEfCore
{
    public interface IProductService
    {
        void CreateProduct(CreateProductViewModel model);
        PaginationViewModel<ProductViewModel> GetProducts(ProductSearchModel model);
    }
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService()
        {
            _context = new AppDbContext();
        }

        public void CreateProduct(CreateProductViewModel model)
        {
            var product = new Product();
            product.Id = Guid.NewGuid();
            product.Name = model.Name;
            product.Price = model.Price;
            product.Quantity = model.Quantity;
            product.CreatedDate = DateTime.Now;
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public PaginationViewModel<ProductViewModel> GetProducts(ProductSearchModel model)
        {
            var result = new PaginationViewModel<ProductViewModel>();
            var query = _context.Products.AsQueryable();
            if (!string.IsNullOrEmpty(model.Keyword))
            {
                query = query.Where(s => s.Name.Contains(model.Keyword));
            }
            result.Total = query.Count();
            query = query.Skip(model.SkipNo).Take(model.PageSize);
            result.Data = query.Select(s => new ProductViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Price = s.Price,
                Quantity = s.Quantity,
                CreatedDate = DateTime.Now,
                Status = s.Status,
            }).ToList();
            return result;

        }

    }
}
