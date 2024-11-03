namespace Demo.Domain.Exceptions;

public static class CategoryException
{
    public class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException(Guid categoryId)
            : base($"The category with the id {categoryId} was not found.")
        {

        }
        
    }

    public class CreateCategoryException : BadRequestException
    {
        public CreateCategoryException(string categoryName)
            : base($"Something when wrong when create category {categoryName}")
        {

        }

    }

    public class UpdateCategoryException : BadRequestException
    {
        public UpdateCategoryException(Guid categoryId)
            : base($"Something when wrong when update category with id: {categoryId}")
        {

        }

    }

    public class DeleteCategoryException : BadRequestException
    {
        public DeleteCategoryException(Guid categoryId)
            : base($"Something when wrong when delete category with id: {categoryId} ")
        {

        }

    }


}
