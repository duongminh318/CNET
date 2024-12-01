using Demo.Domain.ApplicationServices.Users;
using Demo.Persistence;
using Microsoft.EntityFrameworkCore;
using Demo.Application;
using Demo.Infrastructure;
using Demo.Api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//services of persistence
builder.Services.AddSqlServerPersistence(builder.Configuration);
builder.Services.AddRepositoryUnitOfWork();
//service of applications
builder.Services.AddServicesApplication();
//service of infrastructure
builder.Services.AddServicesInfrastructure();
builder.Services.AddOptionsInfrastructure(builder.Configuration);
//service of Api
builder.Services.AddJwtAuthentication(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
InitDatabase(app);
app.Run();

void InitDatabase(IApplicationBuilder app)
{
    using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();

    var dbcontext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dbcontext.Database.Migrate();

    var userService = serviceScope.ServiceProvider.GetRequiredService<IUserService>();
    userService.InitializeUserAdminAsync().Wait();
}
