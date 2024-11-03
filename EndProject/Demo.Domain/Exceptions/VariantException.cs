namespace Demo.Domain.Exceptions;

public static class VariantException
{
    public class VariantNotFoundException : NotFoundException
    {
        public VariantNotFoundException(Guid variantId)
            : base($"The variant with the id {variantId} was not found.")
        {

        }
        
    }

    public class CreateVariantException : BadRequestException
    {
        public CreateVariantException(string variantName)
            : base($"Something when wrong when create variant {variantName}")
        {

        }

    }

    public class UpdateVariantException : BadRequestException
    {
        public UpdateVariantException(Guid variantId)
            : base($"Something when wrong when update variant with id: {variantId}")
        {

        }

    }

    public class DeleteVariantException : BadRequestException
    {
        public DeleteVariantException(Guid variantId)
            : base($"Something when wrong when delete variant with id: {variantId} ")
        {

        }

    }


}
