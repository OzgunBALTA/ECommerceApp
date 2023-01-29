using Autofac.Core;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MvcWebUI.ApiServices.Abstract;
using MvcWebUI.ApiServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();

builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient<ICategoryApiService, CategoryApiManager>();
builder.Services.AddHttpClient<IProductApiService, ProductApiManager>();


builder.Services.AddControllersWithViews();

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
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
