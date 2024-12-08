using Demo.Api.Filters;
using Demo.Domain.ApplicationServices.Users;
using Demo.Domain.Utility;
using DemoApp.Domain.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace Demo.Api.Base
{
    [ApiController]
    [ApplicationAuthorize]
    public class AuthorizeController : ControllerBase
    {
        public string UserName
        {
            get
            {
                return Request.HttpContext.User.Claims
                         .First(i => i.Type == "UserName").Value;

            }
        }
        public string Email
        {
            get
            {
                return Request.HttpContext.User.Claims
                         .First(i => i.Type == "Email").Value;
            }
        }
        public string AccessToken
        {
            get
            {
                var authorization = Request.Headers[HeaderNames.Authorization].ToString();
                var accessToken = string.IsNullOrEmpty(authorization) ? string.Empty : authorization.Substring(7);
                return accessToken;
            }
        }
        
        public UserProfileModel CurrentUser
        {
            get
            {
                var currentUser = HelperUtility.GetValueHeader<UserProfileModel>(Request, CommonConstants.Header.CurrentUser);
                return currentUser ?? new UserProfileModel();
            }
        }
    }
}
