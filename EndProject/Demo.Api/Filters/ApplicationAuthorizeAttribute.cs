using Demo.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace Demo.Api.Filters
{
    public class ApplicationAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }
}