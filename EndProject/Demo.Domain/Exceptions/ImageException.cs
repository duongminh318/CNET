namespace Demo.Domain.Exceptions;

public static class ImageException
{

    public class UploadImageException : BadRequestException
    {
        public UploadImageException()
            : base($"Something when wrong when upload images")
        {

        }
    }

    public class UpdateImageException : BadRequestException
    {
        public UpdateImageException(Guid imageId)
            : base($"Something when wrong when update image with id {imageId}")
        {

        }

    }

    public class DeleteImageException : BadRequestException
    {
        public DeleteImageException(Guid imageId)
            : base($"Something when wrong when delete image with id {imageId}")
        {

        }

    }

    public class ImageNotFoundException : NotFoundException
    {
        public ImageNotFoundException(Guid imageId)
            : base($"Not found image with id: {imageId}")
        {

        }

    }
}
