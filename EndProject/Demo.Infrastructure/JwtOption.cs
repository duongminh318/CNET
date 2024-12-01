namespace DemoApp.Infrastructure.DependencyInjection;

public class JwtOption
{
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SecretKey { get; set; }
    public int ExpireMin { get; set; }
}