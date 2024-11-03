namespace Demo.Domain.ApplicationServices.Users
{
    public class RoleViewModel
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public List<PermissionViewModel> Permissions { get; set; }
        public List<UserViewModel> UsersInRole { get; set; }
       

    }
}
