﻿using LearnDI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddTransient<IServiceA, ServiceA>(); // mỗi lần mỗi tạo
//builder.Services.AddScoped<IServiceA, ServiceA>();      // đã tạo rồi trc đó thì ko tạo nữa
builder.Services.AddSingleton<IServiceA, ServiceA>(); //1 lần duy nhất

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
