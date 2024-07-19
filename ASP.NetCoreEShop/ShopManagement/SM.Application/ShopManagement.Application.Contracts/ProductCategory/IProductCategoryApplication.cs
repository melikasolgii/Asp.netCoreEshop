using System.Collections.Generic;

namespace ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application.Contracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        void Create(CreateProductCategory command);
        void Edit(EditProductCategory command);
        Domain.ProductCategoryAgg.ProductCategory GetDetails(long id);

        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);

    }
}
