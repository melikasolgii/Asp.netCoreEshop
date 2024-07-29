using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application.Contracts.ProductCategory;
using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application;
using ASP.NetCoreEShop.ShopManagement.SM.Domain.ProductCategoryAgg;
using ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Configuration;
using ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Infrastructure.EFCore;
using ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using ASP.NetCoreEShop;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.Addproductmanagementservices(builder.Configuration, builder.Environment);

// Register the DbContext with the connection string

//builder.Services.AddDbContext<ShopContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("LampshadeDB")));

// Register application services and repositories

//builder.Services.AddTransient<IProductCategoryApplication, ProductCategortApplication>();
//   builder.Services.AddTransient<IProductCategoryRepository,ProductCategoryRepository>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{

    app.UseSwagger();
    app.UseSwaggerUI();
   
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapDefaultControllerRoute();
});

app.MapGet("/", () => "Hello World!");

app.Run();
