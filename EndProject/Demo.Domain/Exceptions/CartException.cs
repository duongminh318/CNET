namespace Demo.Domain.Exceptions;

public static class CartException
{
    public class CartItemNotFoundException : NotFoundException
    {
        public CartItemNotFoundException(Guid variantId)
            : base($"The item with the id {variantId} was not found.")
        {

        }
        
    }

    public class ProcessCartException : BadRequestException
    {
        public ProcessCartException()
            : base($"Something when wrong")
        {

        }

    }

    public class OutOfStockException : BadRequestException
    {
        public OutOfStockException(string variantName)
            : base($"{variantName} is out of stock")
        {

        }
    }

    public class CartEmptyException : BadRequestException
    {
        public CartEmptyException()
            : base($"No items in cart")
        {

        }
    }

    
}
