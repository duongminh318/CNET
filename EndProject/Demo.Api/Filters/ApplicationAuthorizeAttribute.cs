using Demo.Domain.ApplicationServices.Users;
using Demo.Domain.Exceptions;
using Demo.Domain.Utility;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Demo.Api.Filters
{
    public class ApplicationAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userName = context.HttpContext.User.Claims?
                        .FirstOrDefault(i => i.Type == "UserName")?.Value ?? string.Empty;

            if (string.IsNullOrEmpty(userName))
            {
                throw new UserException.UnauthorizedException();
            }

            var userService = (IUserService?)context.HttpContext.RequestServices.GetService(typeof(IUserService));
            if (userService != null)
            {
                try
                {
                    var user = userService.GetUserProfile(userName).Result;
                    if (user != null)
                    {
                        var currentUser = new UserProfileModel()
                        {
                            UserId = user.UserId,
                            UserName = user.UserName,
                            Email = user.Email,
                            Permissions = user.Permissions
                        };

                        context.HttpContext.Request.Headers.Add(CommonConstants.Header.CurrentUser, JsonConvert.SerializeObject(currentUser));
                    }
                    else
                    {
                        throw new UserException.UserNotFoundException();
                    }
                }
                catch (Exception ex)
                {
                    throw new UserException.UserNotFoundException();
                }
            }
            else
            {
                throw new UserException.UserNotFoundException();
            }
        }
    }
}