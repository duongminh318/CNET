using Microsoft.AspNetCore.Identity;

namespace Demo.Domain.Entities;

public class AppUser : IdentityUser<Guid>
{
    public bool IsSystemUser { get; set; }
    public virtual ICollection<IdentityUserClaim<Guid>> Claims { get; set; }
    public virtual ICollection<IdentityUserLogin<Guid>> Logins { get; set; }
    public virtual ICollection<IdentityUserToken<Guid>> Tokens { get; set; }
    public virtual ICollection<IdentityUserRole<Guid>> UserRoles { get; set; }
}
