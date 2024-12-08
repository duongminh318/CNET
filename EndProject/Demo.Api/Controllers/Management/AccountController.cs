using Demo.Api.Base;
using Demo.Api.Filters;
using Demo.Domain;
using Demo.Domain.ApplicationServices.Users;
using Demo.Domain.Utility;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers.Management
{

    public class AccountController : AuthorizeController
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPut]
        [Route("update-info")]
        public async Task<ResponseResult> UpdateUserInfo([FromBody] UpdateUserInfoViewModel model)
        {
            var result = await _userService.UpdateUserInfo(model, CurrentUser);
            return result;
        }


        [HttpPut]
        [Route("change-password")]
        
        public async Task<ResponseResult> ChangePassword([FromBody] ChangePasswordViewModel model)
        {
            var result = await _userService.ChangePassword(model, CurrentUser);
            return result;
        }

        [Permission(CommonConstants.Permissions.ADD_USER_PERMISSION)]
        [HttpPost]
        [Route("register-system-user")]
        public async Task<ResponseResult> RegisterSystemUser([FromBody] RegisterUserViewModel model)
        {
            var result = await _userService.RegisterSystemUser(model);
            return result;
        }

        [Permission(CommonConstants.Permissions.UPDATE_ROLE_PERMISSION)]
        [HttpPost]
        [Route("assign-role")]
        public async Task<ResponseResult> AssignRole([FromBody] AssignRolesViewModel model)
        {
            var result = await _userService.AssignRoles(model);
            return result;
        }

        [Permission(CommonConstants.Permissions.UPDATE_ROLE_PERMISSION)]
        [HttpPost]
        [Route("remove-role")]
        public async Task<ResponseResult> RemoveRole([FromBody] RemoveRolesViewModel model)
        {
            var result = await _userService.RemoveRoles(model);
            return result;
        }

        [Permission(CommonConstants.Permissions.UPDATE_ROLE_PERMISSION)]
        [HttpPost]
        [Route("assign-permissions")]
        public async Task<ResponseResult> AssignPermissions([FromBody] AssignPermissionsViewModel model)
        {
            var result = await _userService.AssignPermissions(model);
            return result;
        }

        [Permission(CommonConstants.Permissions.VIEW_USER_PERMISSION)]
        [HttpPost]
        [Route("get-users")]
        public async Task<PageResult<UserViewModel>> GetUsers([FromBody] UserSearchQuery model)
        {
            var result = await _userService.GetUsers(model);
            return result;
        }

        [Permission(CommonConstants.Permissions.VIEW_ROLE_PERMISSION)]
        [HttpPost]
        [Route("get-roles")]
        public async Task<PageResult<RoleViewModel>> GetRoles([FromBody] RoleSearchQuery model)
        {
            var result = await _userService.GetRoles(model);
            return result;
        }

        [Permission(CommonConstants.Permissions.VIEW_ROLE_PERMISSION)]
        [HttpPost]
        [Route("get-role-detail")]
        public async Task<PageResult<RoleViewModel>> GetRoleDetail([FromBody] RoleSearchQuery model)
        {
            var result = await _userService.GetRoles(model);
            return result;
        }
    }
}
