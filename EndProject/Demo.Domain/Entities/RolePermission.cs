using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Domain.Entities
{
    [Table("RolesPermissions")]
    public class RolePermission : DomainEntity<Guid>
	{
        public Guid RoleId { get; set; }
        public string PermissionCode { get; set; } = string.Empty;
    }
}
