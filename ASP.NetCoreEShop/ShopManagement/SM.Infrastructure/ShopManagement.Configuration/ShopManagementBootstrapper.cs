using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application;
using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application.Contracts.ProductCategory;
using ASP.NetCoreEShop.ShopManagement.SM.Domain.ProductCategoryAgg;
using ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Infrastructure.EFCore;
using ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Infrastructure.EFCore.Repository;
using Microsoft.EntityFrameworkCore;

namespace ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Configuration
{
    //dependancy injection
    public class ShopManagementBootstrapper
    {
        //public static void Configure(IServiceCollection services,string connectionString)
        //{
        //    services.AddTransient<IProductCategoryApplication,ProductCategortApplication>();
        //    services.AddTransient<IProductCategoryRepository,ProductCategoryRepository>();


        //    services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
        
        
        //}
    }
  
}
