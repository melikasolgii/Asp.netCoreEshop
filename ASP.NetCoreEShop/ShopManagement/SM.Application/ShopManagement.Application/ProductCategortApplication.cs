using _0_Framework.Application;
using ASP.NetCoreEShop._0_framework.Application;
using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application.Contracts.ProductCategory;
using ASP.NetCoreEShop.ShopManagement.SM.Domain.ProductCategoryAgg;

namespace ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application
{
    public class ProductCategortApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        public ProductCategortApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResult Create(CreateProductCategory command)
        {
           var operation= new OperationResult();
            if(_productCategoryRepository.Exists(x=>x.Name == command.Name))
            {
                return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد .لطفا مجددا تلاش فرمایید!");
            }

            var slug = command.Slug.Slugify();

            var productCategory = new ProductCategory(
                command.Name,
                command.Description,
                command.MetaDescription,
                command.Picture,
                command.PictureTitle,
                command.PictureAlt,
                command.Keywords,
                slug);

            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.SaveChanges();

            return operation.Succedded();
            
        }
 

        public OperationResult Edit(EditProductCategory command)
        {
            var operation = new OperationResult();
            var productCategory = _productCategoryRepository.Get(command.Id);
            if(productCategory is null)
            {
                return operation.Failed("رکورد با اطلاعات درخواست شده یافت نشد .لطفا مجدد تلاش فرمایید");

            }
            if(_productCategoryRepository.Exists(x=>x.Name ==command.Name && x.Id != command.Id))
            {
                return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد .لطفا مجددا تلاش فرمایید!");
            }

            var slug = command.Slug.Slugify();

            productCategory.Edit(
                command.Name,
                command.Description,
                command.MetaDescription,
                command.Picture,
                command.PictureTitle,
                command.PictureAlt,
                command.Keywords,
                slug);
         
            _productCategoryRepository.SaveChanges();
            return operation.Succedded();

                

        }

        public EditProductCategory GetDetails(long id)
        {
            return _productCategoryRepository.GetDetails(id);
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepository.Search(searchModel);
        }
    }
}
