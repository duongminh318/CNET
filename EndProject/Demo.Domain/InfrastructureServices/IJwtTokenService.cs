using System.Security.Claims;

namespace Demo.Domain.InfrastructureServices;

public interface IJwtTokenService
{
    string GenerateAccessToken(IEnumerable<Claim> claims);

}