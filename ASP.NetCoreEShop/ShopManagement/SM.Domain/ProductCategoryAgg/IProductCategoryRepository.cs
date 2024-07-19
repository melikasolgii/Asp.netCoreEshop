namespace ASP.NetCoreEShop.ShopManagement.SM.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository
    {
        void Create(ProductCategory entity);
       
        ProductCategory Get(long id);
        List<ProductCategory> GetAll();
    }
}
