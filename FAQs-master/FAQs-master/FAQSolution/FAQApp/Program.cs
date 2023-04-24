using FAQApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//  Add EF Core DI
builder.Services.AddDbContext<FAQContext>(options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("FAQContext")));

//  Add lowercase URLs and append trailing slash
builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "category",
        pattern: "{controller=Home}/{action=Index}/topic/{topic}/category/{category}");

    endpoints.MapControllerRoute(
        name: "topic",
        pattern: "{controller=Home}/{action=Index}/topic/{topic}");

    endpoints.MapControllerRoute(
        name: "topic",
        pattern: "{controller=Home}/{action=Index}/category/{category}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
