using BookApp.Repositories;
using BookApp.Services.Authors;
using BookApp.Services.Books;
using BookApp.UnitOfWork;
using Ex1RepositoryUOW.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Dependencies
{
    public static class DependencyInjection
    {
        public static void AddDatabase(this IServiceCollection  services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]));
        }

        public static void AddRepositoryUOW(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IBookService, BookService>();
        }

        public static void AddBookAppAuthentication(this IServiceCollection service)
        {
            service.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(option =>
                {
                    option.LoginPath = $"/Account/Login";
                    option.AccessDeniedPath = "/Account/AccessDenied";
                    option.Cookie.HttpOnly = true;
                });
            service.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            service.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = true;
            });
        }


    }
}
