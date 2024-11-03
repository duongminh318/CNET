using Microsoft.AspNetCore.Identity;

namespace Demo.Domain.Entities;

public class AppUser : IdentityUser<Guid>
{
    public bool IsSystemUser { get; set; }
   
}
