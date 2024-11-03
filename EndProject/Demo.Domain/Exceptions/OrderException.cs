namespace Demo.Domain.Exceptions;

public static class OrderException
{
    public class ProcessCheckoutException : BadRequestException
    {
        public ProcessCheckoutException()
            : base($"Some thing wrong happen in checkout process")
        {

        }
    }

    public class UpdateOrderException : BadRequestException
    {
        public UpdateOrderException(Guid orderId)
            : base($"Something when wrong when update order with id: {orderId}")
        {

        }

    }

    


}
