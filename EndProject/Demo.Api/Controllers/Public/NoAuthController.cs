using Demo.Api.Filters;
using Demo.Domain;
using Demo.Domain.ApplicationServices.Users;
using Demo.Domain.Utility;
using DemoApp.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers.Public
{
    public class NoAuthController: NoAuthorizeController
    {
        private readonly IUserService _userService;
        public NoAuthController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("login")]
        public async Task<AuthorizedResponseModel> Login([FromBody] LoginViewModel model)
        {
            //throw new Exception();
            var result = await _userService.Login(model);
            return result;
        }

        [HttpPost]
        [Route("register-customer")]
        public async Task<ResponseResult> RegisterCustomer([FromBody] RegisterUserViewModel model)
        {
            var result = await _userService.RegisterCustomer(model);
            return result;
        }
    }
}
