using Microsoft.AspNetCore.Http;

namespace Demo.Domain.Exceptions;

public static class UserException
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException()
            : base($"User not found") { }
    }

    public class RoleNotFoundException : NotFoundException
    {
        public RoleNotFoundException()
            : base($"Role not found") { }
    }

    public class PasswordNotCorrectException : NotFoundException
    {
        public PasswordNotCorrectException()
            : base($"Password is not correct") { }
    }

    public class UnauthorizedException : BaseException
    {
        public UnauthorizedException()
            : base("Unauthorized", "you are not authorized")
        {
            StatusCode = StatusCodes.Status401Unauthorized;
        }
    }

    public class ForbiddenException : BaseException
    {
        public ForbiddenException()
            : base("Forbidden", "you are not allowed to access  this resource")
        {
            StatusCode = StatusCodes.Status403Forbidden;
        }
    }

    public class HandleUserException : BadRequestException
    {
        public HandleUserException(string message)
            : base(message) { }
    }

}
