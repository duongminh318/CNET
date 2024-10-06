using BookApp.Repositories;
using BookApp.UnitOfWork;
using Ex1RepositoryUOW.Entities;
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

        //public static void AddServices(this IServiceCollection services)
        //{
        //    services.AddScoped<IAuthorService, AuthorService>();
        //    services.AddScoped<IBookService, BookService>();
        //}
    }
}
