using ASP.NetCoreEShop._0_framework.Domain;
using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application.Contracts.ProductCategory;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;

namespace ASP.NetCoreEShop.ShopManagement.SM.Domain.ProductCategoryAgg
{
    public interface IProductCategoryRepository:IRepository<long,ProductCategory >
    {

        EditProductCategory GetDetails(long id);
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
