using ASP.NetCoreEShop._0_framework.Infrastructure;
using ASP.NetCoreEShop.ShopManagement.SM.Application.ShopManagement.Application.Contracts.ProductCategory;
using ASP.NetCoreEShop.ShopManagement.SM.Domain.ProductCategoryAgg;
using System.Linq.Expressions;

namespace ASP.NetCoreEShop.ShopManagement.SM.Infrastructure.ShopManagement.Infrastructure.EFCore.Repository
{
    public class ProductCategoryRepository : RepositoryBase<long,ProductCategory> ,IProductCategoryRepository
    {
        private readonly ShopContext _context ;
        public ProductCategoryRepository( ShopContext context) :base(context) 
        {
            _context = context;
            
        }

        public EditProductCategory GetDetails(long id)
        {
            return _context.ProductCategories.Select(x=> new EditProductCategory()
            {
                Id = x.Id,
                Name = x.Name,
                Description=x.Description,
                MetaDescription=x.MetaDescription,
                Keywords=x.Keywords,
                Slug=x.Slug,
                Picture=x.Picture,
                PictureAlt=x.PictureAlt,
                PictureTitle=x.PictureTitle

            }).FirstOrDefault(x => x.Id == id); //returns the first element of a sequence, or a default value if the sequence is empty
        }


        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            var query = _context.ProductCategories.Select(x => new ProductCategoryViewModel //select for displaying data
            {
                Id = x.Id,
                Name = x.Name,
                CreationDate=x.CreationDate.ToString(),
                Picture=x.Picture

            });
            if(!string.IsNullOrWhiteSpace(searchModel.Name))  //if searchmodel name is not null
            {
                //If the Name property of the searchModel is not null or whitespace,
                //it filters the query to only include product categories whose Name contains the search term.

                query = query.Where(x=>x.Name.Contains(searchModel.Name));
            }
            return query.OrderByDescending(x=> x.Id).ToList();
        }

  
    }
}
