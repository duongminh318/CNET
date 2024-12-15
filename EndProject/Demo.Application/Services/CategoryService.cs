using Demo.Domain;
using Demo.Domain.ApplicationServices.Categories;
using Demo.Domain.ApplicationServices.Users;
using Demo.Domain.Entities;
using Demo.Domain.Enums;
using Demo.Domain.Exceptions;
using Demo.Domain.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Demo.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGenericRepository<Category, Guid> _categoryRepository;
    private readonly IGenericRepository<GeneralImage, Guid> _generalImageRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<CategoryService> _logger;
    public CategoryService(IUnitOfWork unitOfWork,
        IGenericRepository<Category, Guid> categoryRepository,
        IGenericRepository<GeneralImage, Guid> generalImageRepository,
        IHttpContextAccessor httpContextAccessor, ILogger<CategoryService> logger)
    {
        _unitOfWork = unitOfWork;
        _categoryRepository = categoryRepository;
        _generalImageRepository = generalImageRepository;
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
    }

    public async Task<ResponseResult> CreateCategory(CreateCategoryViewModel model, UserProfileModel currentUser)
    {
        var category = new Category()
        {
            Id = Guid.NewGuid(),
            Name = model.CategoryName,
            CreatedBy = currentUser.UserId,
            CreatedDate = DateTime.Now,
        };
        try
        {
            _categoryRepository.Add(category);
            await _unitOfWork.SaveChangesAsync();

            return ResponseResult.Success($"create Category {category.Name} successfully");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message, e);
            throw new CategoryException.CreateCategoryException(model.CategoryName);
        }
    }

    public async Task<ResponseResult> UpdateCategory(UpdateCategoryViewModel model, UserProfileModel currentUser)
    {

        var category = await _categoryRepository.FindByIdAsync(model.CategoryId);
        if (category == null)
        {
            throw new CategoryException.CategoryNotFoundException(model.CategoryId);
        }

        var listImage = await _generalImageRepository
            .FindAll(s => model.ImageIds
                .Contains(s.Id)).Select(s => s.Url).ToListAsync();


        category.Name = model.CategoryName;
        try
        {
            _categoryRepository.Update(category);
            await _unitOfWork.SaveChangesAsync();
            return ResponseResult.Success($"update Category with id {category.Id} successfully");
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message, e);
            throw new CategoryException.UpdateCategoryException(category.Id);
        }
    }

    public async Task<ResponseResult> DeleteCategory(Guid categoryId)
    {

        var category = await _categoryRepository.FindByIdAsync(categoryId);
        if (category == null)
        {
            throw new CategoryException.CategoryNotFoundException(categoryId);
        }

        try
        {
            _categoryRepository.Remove(category);
            await _unitOfWork.SaveChangesAsync();
            return ResponseResult.Success($"delete Category {category.Name} successfully");
        }
        catch (Exception e)
        {
            await _unitOfWork.RollbackAsync();
            _logger.LogError(e.Message, e);
            throw new CategoryException.DeleteCategoryException(category.Id);
        }
    }


    public async Task<CategoryViewModel> GetCategoryById(Guid categoryId)
    {
        var category = await _categoryRepository.FindByIdAsync(categoryId);
        if (category == null)
        {
            throw new CategoryException.CategoryNotFoundException(categoryId);
        }

        var result = new CategoryViewModel()
        {
            CategoryId = categoryId,
            CategoryName = category.Name,
            Status = category.Status,
            Images = category.ImageJson.ConvertToImageViewModel(_httpContextAccessor.HttpContext)

        };
        return result;
    }

    public async Task<PageResult<CategoryViewModel>> GetCategories(CategorySearchQuery query)
    {
        var result = new PageResult<CategoryViewModel>()
        {
            CurrentPage = query.PageIndex
        };
        var categoryQuery = _categoryRepository.FindAll();
        if (query.DisplayActiveItem)
        {
            categoryQuery = categoryQuery.Where(s => s.Status == EntityStatus.Active);
        }
        if (!string.IsNullOrEmpty(query.Keyword))
        {
            categoryQuery = categoryQuery.Where(s => s.Name.Contains(query.Keyword));
        }

        result.TotalCount = await categoryQuery.CountAsync();
        result.Data = await categoryQuery
            .Skip(query.SkipNo).Take(query.TakeNo)
            .Select(s => new CategoryViewModel()
            {
                CategoryId = s.Id,
                CategoryName = s.Name,
                Status = s.Status,
                ImageJson = s.ImageJson

            }).ToListAsync();
        foreach (var item in result.Data)
        {
            item.Images = item.ImageJson.ConvertToImageViewModel(_httpContextAccessor.HttpContext);
            item.ImageJson = string.Empty;
        }
        return result;
    }

    public async Task<ResponseResult> UpdateStatus(UpdateStatusViewModel model)
    {
        var item = await _categoryRepository.FindByIdAsync(model.Id);
        if (item == null)
        {
            throw new CategoryException.CategoryNotFoundException(model.Id);
        }
        item.Status = model.Status;
        _categoryRepository.Update(item);
        try
        {
            await _unitOfWork.SaveChangesAsync();
            return ResponseResult.Success();
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message, e);
            throw new CategoryException.UpdateCategoryException(model.Id);
        }

    }
}



