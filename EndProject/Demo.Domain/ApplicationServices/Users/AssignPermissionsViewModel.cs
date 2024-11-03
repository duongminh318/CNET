namespace Demo.Domain.ApplicationServices.Users
{
    public class AssignPermissionsViewModel
    {
        public Guid RoleId { get; set; }
        public List<PermissionViewModel> Permissions { get; set; }
    }
}
