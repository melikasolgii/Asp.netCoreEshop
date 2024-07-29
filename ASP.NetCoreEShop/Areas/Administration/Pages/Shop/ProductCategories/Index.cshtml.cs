using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NetCoreEShop.Areas.Administration.Pages.Shop.ProductCategories
{
    public class IndexModel : PageModel
    {
        public ProductCategorySearchModel SearchModel;
        public List<ProductCategoryViewModel> ProductCategories;

        private readonly IProductCategoryApplication _productCategoryApplication;
        public IndexModel(IProductCategoryApplication productCategoryApplication)
        {
            _productCategoryApplication = productCategoryApplication;
        }
        public void OnGet(ProductCategorySearchModel searchModel)
        {
           ProductCategories= _productCategoryApplication.Search(searchModel);
        }



        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreateProductCategory());
        }











    }
}
