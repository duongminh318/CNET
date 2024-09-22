using LearnEfCore.Entities;
using LearnEfCore.Models;
using Microsoft.EntityFrameworkCore;
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
        PaginationViewModel<ProductViewModel> GetProductAndVariants(ProductSearchModel model);

        PaginationViewModel<VariantDetailViewModel> GetVariants(VariantSearchModel model);
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

        public PaginationViewModel<ProductViewModel> GetProductAndVariants(ProductSearchModel model)
        {
            var result = new PaginationViewModel<ProductViewModel>();
            var query = _context.Products.Include(s => s.Variants).AsQueryable();
            if (!string.IsNullOrEmpty(model.Keyword))
            {
                query = query.Where(s => s.Name.Contains(model.Keyword));
            }
            result.Total = query.Count();
            query = query.Skip(model.SkipNo).Take(model.PageSize);
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
                Variants = s.Variants.Select(v => new VariantViewModel
                {
                    Id = v.Id,
                    Name = v.Name,
                    Price = v.Price,
                    Quantity = v.Quantity,
                    CreatedDate = v.CreatedDate,
                    Status = v.Status,
                    DiscountPrice = v.DiscountPrice,

                }).ToList()
            }).ToList();
            return result;


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

        public PaginationViewModel<VariantDetailViewModel> GetVariants(VariantSearchModel model)
        {
            var result = new PaginationViewModel<VariantDetailViewModel>();
            var variants = _context.Variants.AsQueryable();
            var products = _context.Products.AsQueryable();

            var query = from p in products
                        join v in variants
                        on p.Id equals v.ProductId
                        select new VariantDetailViewModel
                        {
                            Id = v.Id,
                            Name = v.Name,
                            Price = v.Price,
                            Quantity = v.Quantity,
                            CreatedDate = v.CreatedDate,
                            Status = v.Status,
                            DiscountPrice = v.DiscountPrice,
                            ProductName = p.Name,
                            ProductId = v.ProductId,

                        };
            if (string.IsNullOrEmpty(model.Keyword))
            {
                query = query.Where(s => s.Name.Contains(model.Keyword));
            }
            if (model.ProductId.HasValue)
            {
                query = query.Where(s => s.ProductId == model.ProductId.Value);
            }
            if (model.FromDate.HasValue)
            {
                query = query.Where(s => s.CreatedDate >= model.FromDate.Value);
            }

            if (model.ToDate.HasValue)
            {
                query = query.Where(s => s.CreatedDate <= model.ToDate.Value);
            }
            if (model.Status.HasValue)
            {

                query = query.Where(s => s.Status == model.Status.Value);
            }

            result.Total = query.Count();
            result.Data = query.Skip(model.SkipNo).Take(model.PageSize).ToList();
            return result;
        }

    }
}
