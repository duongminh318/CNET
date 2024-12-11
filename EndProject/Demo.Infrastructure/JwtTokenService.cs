using Demo.Domain.InfrastructureServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Demo.Infrastructure;

public class JwtTokenService : IJwtTokenService
{

    private readonly IOptions<JwtOption> _jwtOption;
    private readonly IConfiguration _configuration;
    public JwtTokenService(IConfiguration configuration, IOptions<JwtOption> jwtOption)
    {
        _jwtOption = jwtOption;
        _configuration = configuration;
    }
    public string GenerateAccessToken(IEnumerable<Claim> claims)
    {
        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOption.Value.SecretKey));
        var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        var tokeOptions = new JwtSecurityToken(
            //issuer: _configuration["JwtOption:Issuer"],
            issuer: _jwtOption.Value.Issuer,
            audience: _jwtOption.Value.Audience,
            claims: claims,
            expires: DateTime.Now.AddMinutes(_jwtOption.Value.ExpireMin),
            signingCredentials: signinCredentials
        );

        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
        return tokenString;
    }


}