using ASP.NetCoreEShop.ShopManagement;

namespace ASP.NetCoreEShop
{
    public static class DependencyInjection
    {
        public static void Addproductmanagementservices(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddProductServices(configuration, env);



        }
    }
}
