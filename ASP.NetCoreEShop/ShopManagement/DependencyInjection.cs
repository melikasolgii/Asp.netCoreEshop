using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application.Contracts.ProductCategory;
using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application;
using Microsoft.EntityFrameworkCore;
using ASP.NetCoreEShop.ShopManagement.SM.Domain.ProductCategoryAgg;
using ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Infrastructure.EFCore.Repository;
using ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Infrastructure.EFCore;

namespace ASP.NetCoreEShop.ShopManagement
{
    public static class DependencyInjection
    {
        public static void AddProductServices(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
        {

            services.AddTransient<IProductCategoryApplication, ProductCategortApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            //database connectionstring 
            services.AddDbContext<ShopContext>(setup =>
            {
                if (env.IsDevelopment())
                {
                    var cnnstr = configuration.GetConnectionString("LampshadeDB");
                    setup.UseSqlServer(cnnstr);

                }
                else
                {
                    //
                }

            });

        }

    }
}
