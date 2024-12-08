using Demo.Application.Services;
using Demo.Domain.ApplicationServices.Images;
using Demo.Domain.ApplicationServices.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Application;

public static class ServiceCollectionExtensions
{
    public static void AddServicesApplication(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IImageService, ImageService>();
    }

}