namespace Demo.Domain.Exceptions;

public static class ProductException
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException(Guid productId)
            : base($"The product with the id {productId} was not found.")
        {

        }
    }
    public class CreateProductException : BadRequestException
    {
        public CreateProductException(string productName)
            : base($"Something when wrong when create variant {productName}")
        {

        }

    }

    public class UpdateProductException : BadRequestException
    {
        public UpdateProductException(Guid productId)
            : base($"Something when wrong when update product with id: {productId}")
        {

        }

    }

    public class DeleteProductException : BadRequestException
    {
        public DeleteProductException(Guid productId)
            : base($"Something when wrong when delete product with id: {productId} ")
        {

        }

    }

    public class CreateReviewException : BadRequestException
    {
        public CreateReviewException()
            : base($"Something when wrong when create review")
        {

        }

    }


}
