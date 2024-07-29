using ASP.NetCoreEShop.ShopManagement.SM.Domain.ProductCategoryAgg;
using ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Infrastructure.EFCore.Mapping;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;

namespace ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Infrastructure.EFCore
{
    public class ShopContext:DbContext
    {
 

        public ShopContext(DbContextOptions<ShopContext> options) :base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var assembly = typeof(ProductCategoryMapping).Assembly;
            //modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.HasDefaultSchema("LampshadeDB");
        }
        public DbSet<ProductCategory> ProductCategories =>Set<ProductCategory>();
    }
}
