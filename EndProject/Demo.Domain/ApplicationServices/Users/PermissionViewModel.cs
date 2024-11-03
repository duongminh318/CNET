namespace Demo.Domain.ApplicationServices.Users
{
    public class PermissionViewModel
    {
        public string PermissionCode { get; set; }
        public string ParentPermissionCode { get; set; }
        public string PermissionName { get; set; }
        public int Index { get; set; }
        public bool IsInRole { get; set; }
    }
}
