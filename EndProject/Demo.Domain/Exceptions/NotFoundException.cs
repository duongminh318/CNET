using Microsoft.AspNetCore.Http;

namespace Demo.Domain.Exceptions;

public abstract class NotFoundException : BaseException
{
    protected NotFoundException(string message)
        : base("Not Found", message)
    {
        StatusCode = StatusCodes.Status404NotFound;
    }
}
