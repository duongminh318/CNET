using Microsoft.AspNetCore.Identity;

namespace Demo.Domain.Entities;

public class AppRole : IdentityRole<Guid>
{
    public virtual ICollection<IdentityUserRole<Guid>> UserRoles { get; set; }
    public virtual ICollection<IdentityRoleClaim<Guid>> Claims { get; set; }

}
